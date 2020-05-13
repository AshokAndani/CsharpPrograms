// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotesManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationBusiness.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common.ControllerModels;
    using Common.Models;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// this is an Interface which has the methods for CRUD operations with Database
    /// </summary>
    public interface INotesManager
    {
        /// <summary>
        /// To Add the Notes
        /// </summary>
        /// <param name="model">From body</param>
        /// <param name="file">Imange File from body</param>
        /// <returns>Result</returns>
        int AddNote(string email, AddNoteModel model, IFormFile file);

        /// <summary>
        /// To remove the Note
        /// </summary>
        /// <param name="NoteId">FromBody</param>
        /// <returns>Result</returns>
        int RemoveNote(string email, int NoteId);

        /// <summary>
        /// To Make A Note Trash
        /// </summary>
        /// <param name="NoteId">FromBody</param>
        /// <returns>Result</returns>
        int isTrash(string email, int NoteId);

        /// <summary>
        /// To make the Note Archive
        /// </summary>
        /// <param name="NoteId">FromBody</param>
        /// <returns>result</returns>
        int isArchive(string email, int NoteId);

        /// <summary>
        /// To Pin a Note
        /// </summary>
        /// <param name="NoteId">FromBody</param>
        /// <returns>Result</returns>
        int Pin(string email, int NoteId);

        /// <summary>
        /// To Get Note by Id
        /// </summary>
        /// <param name="NoteId">FromBody</param>
        /// <returns>Result</returns>
        NotesModel GetNote(string email, int NoteId);

        /// <summary>
        /// To Get All the Notes
        /// </summary>
        /// <returns>Result</returns>
        IEnumerable<NotesModel> GetAllNotes(string email);

        /// <summary>
        /// To Update Existing Note
        /// </summary>
        /// <param name="model">FromBody</param>
        /// <returns>Result</returns>
        int UpdateNote(string email, UpdateNoteModel model, IFormFile file);

        /// <summary>
        /// To get the trash notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        List<NotesModel> TrashNotes(string email);

        /// <summary>
        /// to get the Archived Notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IEnumerable<NotesModel> ArchivedNotes(string email);

        /// <summary>
        /// Get the pinned notes
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IEnumerable<NotesModel> PinnedNotes(string email);

        /// <summary>
        /// To Add the image
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        string AddImage(IFormFile file);

        /// <summary>
        /// To Add Collaborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddCollaboratorToNote(CollaboratorModel model);

        /// <summary>
        /// To Remove the Collaborator
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int RemovecollaboratorFromNote(CollaboratorModel model);

        /// <summary>
        /// To Get the Collaborated notes
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        List<NotesModel> GetCollabNotes(string sender);

        /// <summary>
        /// To Get the LabelNotes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        dynamic GetNotLabels(int id, string email);
        List<NotesModel> SearchInNotes(string email, string word);
        List<LabelsModel> SearchInLabels(string email, string word);
        dynamic SendPushNotification(string DeviceToken, string msg, string title);
    }
}
