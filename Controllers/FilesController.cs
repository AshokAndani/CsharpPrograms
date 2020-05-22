// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilesController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FIleUpload.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;

    /// <summary>
    /// this controller is used to Upload the files
    /// </summary>
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        /// <summary>
        /// this Action has the option to upload a single file per request
        /// </summary>
        /// <param name="file">Upload</param>
        /// <returns>Result</returns>
        [HttpPost, Route("SingleFileUpload")]
        public async Task<IActionResult> UploadOneFile(IFormFile file)
        {
            var s = new Stopwatch();
            s.Start();
            if (file.FileName==null||file.Length==0)
            {
                return this.Content("File not Selected");
            }
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
            using(var stream =new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            s.Stop();
            return this.Ok(file.FileName + " with " + file.Length + " uploaded Succefully" + " and took " + s.ElapsedMilliseconds + "   MilliSeconds");
        }

        /// <summary>
        /// to upload multiple files at a request
        /// </summary>
        /// <param name="files">Files</param>
        /// <returns></returns>
        [HttpPost, Route("UploadMultipleFiles")]
        public async Task<IActionResult> UploadMultipleFiles(List<IFormFile> files)
        {
            var so = files.FirstOrDefault();
            var s = new Stopwatch();
            s.Start();
            if (files == null)
            {
                return this.BadRequest("File Not Selected");
            }
            foreach (var file in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            s.Stop();
            return this.Ok("Successfully uploaded with "+s.ElapsedMilliseconds + " milli-Seconds");
        }

        /// <summary>
        /// to check the threads created by our project
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("availableThreads")]
        public IActionResult test1()
        {
            int w, e;
            ThreadPool.GetAvailableThreads(out w, out e);
            return this.Ok("Worker Threads :"+w+" I/O threads: "+e);
        }

        /// <summary>
        /// this action will upload the files using Thread class
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost, Route("ThreadedUpload")]
        public IActionResult Upload(List<IFormFile> files)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            if (files == null)
            {
                return this.BadRequest("File Not Selected");
            }
            files.ForEach(x => new Thread(() => copy(x)).Start());
            s.Stop();
            return this.Ok("Successfully uploaded with " + s.ElapsedMilliseconds+" milli-Seconds");
        }
        
        /// <summary>
        /// Normal File Upload
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost, Route("NormalUpload")]
        public IActionResult NormalUpload(List<IFormFile> files)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            if (files == null)
            {
                return this.BadRequest("File Not Selected");
            }
            files.ForEach(x => copy(x));
            s.Stop();
            return this.Ok("Successfully uploaded with " + s.ElapsedMilliseconds + " milli-Seconds");
        }

        /// <summary>
        /// File Upload Using AsyncUpload
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost, Route("AsyncUpload")]
        public IActionResult AsyncUpload(List<IFormFile> files)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            if (files == null)
            {
                return this.BadRequest("File Not Selected");
            }
            files.ForEach(async x  =>   await CopyAsync(x));
            s.Stop();
            return this.Ok("Successfully uploaded with " + s.ElapsedMilliseconds + " milli-Seconds");
        }

        /// <summary>
        /// Synchronous Copy of Files
        /// </summary>
        /// <param name="file"></param>
        private void copy(IFormFile file)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
        }

        /// <summary>
        /// Asynchronous Copy of Files
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private async Task CopyAsync(IFormFile file)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
        //[HttpPost, Route("MultipleUploadWithBackground")]
        //public IActionResult BackgroundUpload(List<IFormFile> files)
        //{
        //    var s = new Stopwatch();
        //    s.Start();
        //    if(files==null)
        //    {
        //        return this.BadRequest("Files not Selected");
        //    }
        //    BackgroundWorker worker;
        //    files.ForEach(x => (() => copy(x)).Start());
        //    s.Stop();
        //    return this.Ok("Successfully uploaded with " + s.ElapsedMilliseconds + " milli-Seconds");
        //}
    }
}
