// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationBusiness.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ApplicationBusiness.Interfaces;
    using ApplicationRepository.Interfaces;
    using Common.ControllerModels;
    using Common.Models;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// this method implements the INotesManager
    /// </summary>
    public class NotesManagerImpl : INotesManager
    {
        /// <summary>
        /// Private field of INotesRepository
        /// </summary>
        private readonly INotesRepository repository;

        /// <summary>
        /// Constructor Injection of INotesRepository
        /// </summary>
        /// <param name="repository">injects the INotesRepository</param>
        public NotesManagerImpl(INotesRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// To Add the Collaborator to the Notes
        /// </summary>
        /// <param name="model">model</param>
        /// <returns>integer result</returns>
        public int AddCollaboratorToNote(CollaboratorModel model)
        {
            return this.repository.AddCollaboratorToNote(model);
        }

        /// <summary>
        /// To Add the Image
        /// </summary>
        /// <param name="file">multi-part file</param>
        /// <returns>URL of the image in Cloud</returns>
        public string AddImage(IFormFile file)
        {
            return this.repository.NoteImage(file);
        }

        /// <summary>
        /// To AddNote
        /// </summary>
        /// <param name="model">FromBody</param>
        /// <param name="file">File FromBody</param>
        /// <returns>Result</returns>
        public int AddNote(string email, AddNoteModel model, IFormFile file)
        {
            return this.repository.AddNote(email,model, file);
        }

        /// <summary>
        /// To get the Achived Notes
        /// </summary>
        /// <param name="email">User Email</param>
        /// <returns>List of Notes</returns>
        public IEnumerable<NotesModel> ArchivedNotes(string email)
        {
            return this.repository.AchivedNotes(email);
        }

        /// <summary>
        /// To Get All the Notes of the user
        /// </summary>
        /// <param name="email">User Email</param>
        /// <returns>Result</returns>
        public IEnumerable<NotesModel> GetAllNotes(string email)
        {
            return this.repository.GetAllNotes(email);
        }

        /// <summary>
        /// To get the note by email and note id
        /// </summary>
        /// <param name="email">User Email</param>
        /// <param name="NoteId">Note id</param>
        /// <returns>NotesModel</returns>
        public NotesModel GetNote(string email, int NoteId)
        {
            return this.repository.GetNote(email, NoteId);
        }

        /// <summary>
        /// making an note archive and vice versa
        /// </summary>
        /// <param name="email">User Email</param>
        /// <param name="NoteId">NoteId</param>
        /// <returns>Result</returns>
        public int isArchive(string email, int NoteId)
        {
            return this.repository.Archive(email, NoteId);
        }

        /// <summary>
        /// Making an note Archive and vice versa
        /// </summary>
        /// <param name="email">User Email</param>
        /// <param name="NoteId">noteId</param>
        /// <returns>Result</returns>
        public int isTrash(string email, int NoteId)
        {
            return this.repository.Trash(email, NoteId);
        }

        /// <summary>
        /// making an note pin and vice versa
        /// </summary>
        /// <param name="email">user email</param>
        /// <param name="NoteId">noteId</param>
        /// <returns>Result</returns>
        public int Pin(string email, int NoteId)
        {
            return this.repository.Pin(email, NoteId);
        }

        /// <summary>
        /// get all the pinned notes
        /// </summary>
        /// <param name="email">user email</param>
        /// <returns>Result</returns>
        public IEnumerable<NotesModel> PinnedNotes(string email)
        {
            return this.repository.PinnedNotes(email);
        }

        /// <summary>
        /// to remove an collaborator from the note
        /// </summary>
        /// <param name="model">Collaborator Note</param>
        /// <returns>Result</returns>
        public int RemovecollaboratorFromNote(CollaboratorModel model)
        {
            return this.RemovecollaboratorFromNote(model);
        }

        /// <summary>
        /// to remove the Note
        /// </summary>
        /// <param name="email">User Email</param>
        /// <param name="NoteId">noteId</param>
        /// <returns></returns>
        public int RemoveNote(string email, int NoteId)
        {
            return this.repository.RemoveNote(email, NoteId);
        }

        /// <summary>
        /// To Get All the Trashed notes
        /// </summary>
        /// <param name="email">User Email</param>
        /// <returns>List of NotesModel</returns>
        public List<NotesModel> TrashNotes(string email)
        {
            return new List<NotesModel>(this.repository.TrashNotes(email));
        }

        /// <summary>
        /// to upadte the Note
        /// </summary>
        /// <param name="email">User Email</param>
        /// <param name="model">UpdateModel</param>
        /// <param name="file">image file</param>
        /// <returns>Result</returns>
        public int UpdateNote(string email, UpdateNoteModel model, IFormFile file)
        {
            var imageUrl = this.repository.NoteImage(file);
            var newModel = new NotesModel
            {
                Colour = model.Colour,
                Title = model.Title,
                Email = email,
                Id=0,
                Description=model.Description,
                Reminder=model.Reminder,
                Image=imageUrl,
            };
            return this.repository.UpdateNote(newModel);
        }

        /// <summary>
        /// To Get the Collab Notes
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public List<NotesModel> GetCollabNotes(string sender)
        {
            return this.repository.GetCollabNotes(sender);
        }

        /// <summary>
        /// To get the NoteLabels
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public dynamic GetNotLabels(int id, string email)
        {
            if(id!=0 && email!=null)
            {
                return this.repository.GetNotesLabels(id, email);
            }
            return null;
        }

        public List<NotesModel> SearchInNotes(string email, string word)
        {
            if(word!=null)
            {
                return this.repository.Search(email, word);
            }
            return null;
        }

        public List<LabelsModel> SearchInLabels(string email, string word)
        {
            if(word!=null)
            {
                return this.repository.SearchLabels(email, word);
            }
            return null;
        }
        public dynamic SendPushNotification(string DeviceToken, string msg, string title)
        {
            return this.repository.SendPushNotification(DeviceToken, msg, title);
        }
    }
}
