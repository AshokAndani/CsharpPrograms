// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotesRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationRepository.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Common.ControllerModels;
    using Common.Models;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// this interface provides CRUD operation to work with Database
    /// </summary>
    public interface INotesRepository
    {
        /// <summary>
        /// Adds the New Note
        /// </summary>
        /// <param name="model">From Controller</param>
        /// <param name="file">From Controller</param>
        /// <returns>Result</returns>
        int AddNote(string email, AddNoteModel model, IFormFile file);

        /// <summary>
        /// To Remove Note From the database
        /// </summary>
        /// <param name="id">From Controller</param>
        /// <returns>Result</returns>
        int RemoveNote(string email, int id);

        /// <summary>
        /// To Get the Note
        /// </summary>
        /// <param name="id">From Controller</param>
        /// <returns>Result</returns>
        NotesModel GetNote(string email, int id);

        /// <summary>
        /// Gets All notes
        /// </summary>
        /// <returns>Result</returns>
        IEnumerable<NotesModel> GetAllNotes(string email);

        /// <summary>
        /// Update the existing Note to database
        /// </summary>
        /// <param name="model">From Controller</param>
        /// <returns>Result</returns>
        int UpdateNote(NotesModel model);

        /// <summary>
        /// To Save Image to the Cloudinary
        /// </summary>
        /// <param name="file">From Form</param>
        /// <returns>Url</returns>
        string NoteImage(IFormFile file);

        /// <summary>
        /// To Archive a Note
        /// </summary>
        /// <param name="id">From Controller</param>
        /// <returns>Result</returns>
        int Archive(string email, int id);

        /// <summary>
        /// To Pin a Note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Pin(string email, int id);

        /// <summary>
        /// to make the trash
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        int Trash(string email, int id);

        /// <summary>
        /// to get list of NotesModel
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IEnumerable<NotesModel> AchivedNotes(string email);

        /// <summary>
        /// to get the trashed notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IEnumerable<NotesModel> TrashNotes(string email);

        /// <summary>
        /// To get the Pinned notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IEnumerable<NotesModel> PinnedNotes(string email);

        /// <summary>
        /// To Add the Collaborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddCollaboratorToNote(CollaboratorModel model);

        /// <summary>
        /// to remove collaborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int RemoveCollaboratorFromNote(CollaboratorModel model);

        /// <summary>
        /// to get the list of collaborated notes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="reciever"></param>
        /// <returns></returns>
        List<NotesModel> GetCollabNotes(string sender);

        dynamic GetNotesLabels(int id, string email);
        dynamic SendPushNotification(string DeviceToken, string msg, string title);
        List<NotesModel> Search(string email, string word);
        List<LabelsModel> SearchLabels(string email, string word);
    }
}
