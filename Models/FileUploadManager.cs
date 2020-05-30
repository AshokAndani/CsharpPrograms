// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UploadManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ChunkFileUploads.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Threading;
    using System.IO;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// this class has the methods to work with merging the uploaded chunkfiles
    /// </summary>
    public class FileUploadManager
    {
        /// <summary>
        /// this instance is used to lock the code
        /// </summary>
        static volatile Object LockerObject = new object();

        /// <summary>
        /// the Merge method is used to merge all the chunk files into one
        /// </summary>
        /// <param name="FileName">Chunk File Name</param>
        public void MergeFiles(string FileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var token = ".part_";
            var ActualFileName = FileName.Substring(0, FileName.IndexOf(token));
            var MyContent = FileName.Substring(FileName.LastIndexOf(token) + token.Length);
            int TotalFileCount = 0;
            int.TryParse(MyContent.Substring(MyContent.IndexOf(".") + 1), out TotalFileCount);
            var Files = Directory.GetFiles(path, ActualFileName + "*");
            var ActualFilePath = Path.Combine(path, ActualFileName);
            if (Files.Length == TotalFileCount)
            {
                var FileList = GetSortedList(Files).ToList();
                lock (LockerObject)
                {
                    bool flag = true;
                    if (flag)
                    {
                        using (var ParentFile = new FileStream(ActualFilePath, FileMode.Create))
                        {
                            foreach (var file in FileList)
                            {
                                using (var ChildFile = new FileStream(file.Value, FileMode.Open))
                                {
                                    ChildFile.CopyTo(ParentFile);
                                    ChildFile.Close();
                                }
                                System.IO.File.Delete(file.Value);
                            }
                            ParentFile.Close();
                            //// FileList.ForEach(x => System.IO.File.Delete(x.Value));
                            flag = false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// to list the Chunk files based on order by sorting them
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        private SortedList<int, string> GetSortedList(string[] files)
        {
            int FileNumber = 0;
            SortedList<int, string> result = new SortedList<int, string>();
            foreach (var FileName in files)
            {
                var token = ".part_";
                var MyContent = FileName.Substring(FileName.LastIndexOf(token) + token.Length);
                int.TryParse(MyContent.Substring(0, MyContent.IndexOf(".")), out FileNumber);
                result.Add(FileNumber, FileName);
            }
            return result;
        }

        /// <summary>
        /// this method copies the uploaded file into the Server Memory
        /// </summary>
        /// <param name="file">Uploaded File</param>
        public void Copy(IFormFile file)
        {
            lock (LockerObject)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                using (var FileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    file.CopyTo(FileStream);
                    FileStream.Flush();
                }
            }
        }
    }
}
