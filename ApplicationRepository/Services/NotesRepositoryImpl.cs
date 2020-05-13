// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesRepositoryImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationRepository.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using ApplicationRepository.Context;
    using ApplicationRepository.Interfaces;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Common.ControllerModels;
    using Common.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Caching.Distributed;
    using Microsoft.Extensions.Caching.Redis;
    using Newtonsoft.Json;

    /// <summary>
    /// Implementation Class of INotesRepository
    /// </summary>
    public class NotesRepositoryImpl : INotesRepository
    {
        /// <summary>
        /// AppDbContext Field
        /// </summary>
        private readonly AppDbContext context;

        /// <summary>
        /// Distributed Cache Field
        /// </summary>
        private readonly IDistributedCache distributedCache;

        /// <summary>
        /// Injecting the Objects in Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="distributedCache"></param>
        public NotesRepositoryImpl(AppDbContext context, IDistributedCache distributedCache)
        {
            this.context = context;
            this.distributedCache = distributedCache;
        }

        /// <summary>
        /// To Get the List of Archived Notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public IEnumerable<NotesModel> AchivedNotes(string email)
        {
            return this.context.Notes.Where(o => o.IsArchive == true && o.Email == email);
        }

        /// <summary>
        /// To Add the Nots
        /// </summary>
        /// <param name="email"></param>
        /// <param name="model"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public int AddNote(string email, AddNoteModel model, IFormFile file)
        {
            //// Getting the cloud link of the Image
            var imagePath = this.NoteImage(file);
            //// Creating the NotesModel Object and Copying the incoming object Details
            var NewModel = new NotesModel
            {
                Colour = model.Colour,
                CreatedDate = DateTime.UtcNow,
                ModeifiedDate = DateTime.UtcNow,
                Description = model.Description,
                IsArchive = false,
                IsPin = false,
                IsTrash = false,
                Title = model.Title,
                Reminder = model.Reminder,
                Image = imagePath,
                Email = email,
            };
            this.context.Notes.Add(NewModel);
            return this.context.SaveChanges();
        }

        /// <summary>
        /// To Archive a note
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Archive(string email, int id)
        {
            var note = this.context.Notes.FirstOrDefault(o => o.Id == id && o.Email == email && o.IsTrash == false);
            if (note != null)
            {
                if (note.IsArchive == false)
                {
                    note.IsArchive = true;
                }
                else
                {
                    note.IsArchive = false;
                }
                this.context.Notes.Update(note);
                return this.context.SaveChanges();
            }
            return 0;
        }

        /// <summary>
        /// to get all the notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public IEnumerable<NotesModel> GetAllNotes(string email)
        {
            var CacheString = this.distributedCache.GetString("noteList");
            if (CacheString == null)
            {
                var tempList = this.PutListToCache(email);
                return tempList.Where(o => o.IsArchive == false && o.IsTrash == false).ToList();
            }
            else
            {
                var tempList = this.getListFromCache("noteList");
                return tempList.Where(o => o.IsArchive == false && o.IsTrash == false).ToList();
            }
        }

        /// <summary>
        /// to get the note
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public NotesModel GetNote(string email, int id)
        {
            var CacheString = this.distributedCache.GetString("noteList");
            if (CacheString == null)
            {
                var tempList = this.PutListToCache(email);
                return tempList.Find(o => o.IsArchive == false && o.IsTrash == false && o.Email == email && o.Id == id);
            }
            else
            {
                var tempList = this.getListFromCache("noteList");
                return tempList.Find(o => o.IsArchive == false && o.IsTrash == false && o.Email == email && o.Id == id);
            }
        }

        /// <summary>
        /// to get the list from Cache
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<NotesModel> getListFromCache(string key)
        {
            var CacheString = this.distributedCache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<NotesModel>>(CacheString).ToList();
        }

        /// <summary>
        /// to put list to the Cache
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public List<NotesModel> PutListToCache(string email)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
            var Enlist = this.context.Notes.Where(o => o.Email == email);
            var jsonString = JsonConvert.SerializeObject(Enlist);
            this.distributedCache.SetString("noteList", jsonString, options);
            return Enlist.ToList();
        }

        /// <summary>
        /// Adding the NoteImage to the Cloud
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string NoteImage(IFormFile file)
        {
            if (file == null)
            {
                return null;
            }
            var FilePath = file.OpenReadStream();
            var name = file.FileName;
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account("dhnyx69a1", "963552364485736", "BjAcd24zzsy1xlz--uMFURyE0qQ");
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var uploadParameters = new ImageUploadParams()
            {
                File = new FileDescription(name, FilePath)
            };
            var result = cloudinary.Upload(uploadParameters);
            return result.Uri.ToString();
        }

        /// <summary>
        /// to pin the note
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Pin(string email, int id)
        {
            var note = this.context.Notes.FirstOrDefault(o => o.Id == id && o.Email == email);
            if (note != null)
            {
                if (note.IsPin == false)
                {
                    note.IsPin = true;
                }
                else
                {
                    note.IsPin = false;
                }
                this.context.Notes.Update(note);
                return this.context.SaveChanges();
            }
            return 0;
        }

        /// <summary>
        /// to get the list of pinned notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public IEnumerable<NotesModel> PinnedNotes(string email)
        {
            return this.context.Notes.Where(o => o.IsPin == true && o.Email == email);
        }

        /// <summary>
        ///  to remove the notes
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int RemoveNote(string email, int id)
        {
            var note = this.context.Notes.FirstOrDefault(o => o.Id == id && o.Email == email);
            if (note != null)
            {
                this.context.Notes.Remove(note);
                return this.context.SaveChanges();
            }
            return 0;
        }

        /// <summary>
        /// to Trash the notes
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Trash(string email, int id)
        {
            var note = this.context.Notes.FirstOrDefault(o => o.Id == id && o.Email == email);
            if (note != null)
            {
                if (note.IsTrash == false)
                {
                    note.IsTrash = true;
                }
                else
                {
                    note.IsTrash = false;
                }
                this.context.Notes.Update(note);
                return this.context.SaveChanges();
            }
            return 0;
        }

        /// <summary>
        /// to get the trashed notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public IEnumerable<NotesModel> TrashNotes(string email)
        {
            return this.context.Notes.Where(o => o.IsTrash == true && o.Email == email);
        }

        /// <summary>
        /// to update the note
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateNote(NotesModel model)
        {
            var existing = this.context.Notes.FirstOrDefault(o => o.Id == model.Id);
            if (existing != null)
            {
                //// changing only updated fields
                existing.ModeifiedDate = DateTime.Now;
                existing.Colour = model.Colour ?? existing.Colour;
                existing.Description = model.Description ?? existing.Description;
                existing.Image = model.Image ?? existing.Image;
                existing.Reminder = model.Reminder ?? existing.Reminder;
                existing.Title = model.Title ?? existing.Title;
                this.context.Notes.Update(existing);

                var result = this.context.SaveChanges();
                if (result == 1)
                {
                    return result;
                }
            }
            return 0;
        }

        /// <summary>
        /// To Add the Colaborator to the note
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddCollaboratorToNote(CollaboratorModel model)
        {
            var Note = this.context.Notes.FirstOrDefault(o => o.Id == model.NoteId);
            if (Note != null)
            {
                if (this.context.Collaborators.FirstOrDefault(o => o.NoteId == model.NoteId) == null)
                {
                    this.context.Collaborators.Add(model);
                    return this.context.SaveChanges();
                }
            }
            return 0;
        }

        /// <summary>
        /// to remove the Collborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int RemoveCollaboratorFromNote(CollaboratorModel model)
        {
            var collaborator = this.context.Collaborators.FirstOrDefault(o => o.RecieverEmail == model.RecieverEmail);
            if (collaborator != null)
            {
                this.context.Collaborators.Remove(collaborator);
                return this.context.SaveChanges();
            }
            return 0;
        }

        /// <summary>
        /// to get the collaborated notes
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public List<NotesModel> GetCollabNotes(string sender)
        {
            var Collabed_note_id = this.context.Collaborators.Where(o => o.RecieverEmail.Equals(sender));
            return this.context.Notes.Where(o => Collabed_note_id.Any(d => d.NoteId == o.Id)).ToList();
        }

        /// <summary>
        /// to fetch the notes and labels to display
        /// </summary>
        /// <param name="id">form page</param>
        /// <param name="email">form page</param>
        /// <returns>List of NoteLabelsModel</returns>
        public dynamic GetNotesLabels(int id, string email)
        {
            var result = context.Notes.Where(o => o.Id == id && o.Email == email)
                .Join(context.Labels,
                note => note.Id,
                labels => labels.NoteId,
                (note, labels) => new
                {
                    NoteId = note.Id,
                    LabelId = labels.Id,
                    label = labels.Label,
                    title = note.Title,
                    NoteClr = note.Colour,
                    NoteCreated = note.CreatedDate,
                    NoteDescription = note.Description,
                    NoteImage = note.Image,
                    NoteReminder = note.Reminder,
                }).ToList();
            return result;
        }

        public dynamic SendPushNotification(string DeviceToken, string msg, string title)
        {
            string serverKey = "AAAAXAVjc2c:APA91bEl-9-9f1TbXe0FCRW7IEokbP3MwVwutMTPU40vWN8g9obU9qF3QycNsFq_tltrihPikqjg05Yh8Oo4Ik7znZ7JNwG76awCl_Ahokj3mEEBvLiVxeYVR8SYvnNwZeNXYCRoKGIz";
            string senderId = "395227394919";
            var result = "-1";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://fcm.googleapis.com/fcm/send");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add(string.Format("Authorization: key={0}", serverKey));
            httpWebRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
            httpWebRequest.Method = "POST";
            var payload = new
            {
                to = DeviceToken,
                priority = "high",
                content_available = true,
                notification = new
                {
                    body = msg,
                    title = title
                },
            };
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(payload);
                streamWriter.Write(json);
                streamWriter.Flush();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return null;
        }

        public List<NotesModel> Search(string email, string word)
        {
            var result = this.context.Notes.Where(o =>o.Email==email && (o.Description.Contains(word)|| o.Title.Contains(word)
            ||o.Reminder.Contains(word))).ToList();
            return result;
        }
        public List<LabelsModel> SearchLabels(string email, string word)
        {
            var result = this.context.Labels.Where(o => o.Email == email && o.Label.Contains(word)).ToList();
            return result;
        }
    }
}
