// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using ApplicationBusiness.Interfaces;
    using Common.ControllerModels;
    using Common.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// this Controller is used to Control the Notes
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly INotesManager manager;
        public NotesController(INotesManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// To add the notes
        /// </summary>
        /// <param name="file">Multi-part</param>
        /// <param name="model">Model</param>
        /// <returns>Result</returns>
        [HttpPost, Route("AddNote")]
        public IActionResult AddNote(IFormFile file, AddNoteModel model)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            if (ModelState.IsValid && email != null)
            {
                var result = this.manager.AddNote(email, model, file);
                if (result == 1)
                {
                    return this.Ok();
                }
                return this.NotFound();
            }
            return this.BadRequest();
        }

        /// <summary>
        /// To update the Notes Model
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut, Route("updatenote")]
        public IActionResult UpdateNote(IFormFile file, UpdateNoteModel model)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            if (ModelState.IsValid && email != null)
            {
                var result = this.manager.UpdateNote(email, model, file);
                if (result == 1)
                {
                    return this.Ok();
                }
                return this.NotFound();
            }
            return this.BadRequest();
        }

        /// <summary>
        /// to delete the note
        /// </summary>
        /// <param name="NoteId"></param>
        /// <returns></returns>
        [HttpDelete, Route("deletenote")]
        public IActionResult DeleteNote(int NoteId)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.RemoveNote(email, NoteId);
            if (result == 1)
            {
                return Ok();
            }
            return this.NotFound();
        }

        /// <summary>
        /// to get the note
        /// </summary>
        /// <param name="NoteId"></param>
        /// <returns></returns>
        [HttpGet, Route("getnote")]
        public IActionResult GetNote(int NoteId)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.GetNote(email, NoteId);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// to get all the notes
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("getnotes")]
        public IActionResult GetNotes()
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.GetAllNotes(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// to make the notes trash
        /// </summary>
        /// <param name="NoteId"></param>
        /// <returns></returns>
        [HttpGet, Route("trash")]
        public IActionResult Trash(int NoteId)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch (Exception e)
            {
                email = null;
            }
            var result = this.manager.isTrash(email, NoteId);
            if (result == 1)
            {
                return this.Ok();
            }
            return this.NotFound();
        }

        /// <summary>
        /// to pin the note
        /// </summary>
        /// <param name="NoteId"></param>
        /// <returns></returns>
        [HttpGet, Route("pin")]
        public IActionResult Pin(int NoteId)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.Pin(email, NoteId);
            if (result == 1)
            {
                return this.Ok();
            }
            return this.NotFound();
        }

        /// <summary>
        /// to archive the note
        /// </summary>
        /// <param name="NoteId"></param>
        /// <returns></returns>
        [HttpGet, Route("archive")]
        public IActionResult Archive(int NoteId)
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.isArchive(email, NoteId);
            if (result == 1)
            {
                return this.Ok();
            }
            return this.NotFound();
        }

        /// <summary>
        /// to get the archived notes
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("archivednotes")]
        public IActionResult Archived()
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.ArchivedNotes(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// to get the trashed notes
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("trashnotes")]
        public IActionResult TrashNotes()
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.TrashNotes(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// to get the pinned notes
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("pinnednotes")]
        public IActionResult GetPinnedNotes()
        {
            string email;
            try
            {
                email = User.Identity.Name;
            }
            catch
            {
                email = null;
            }
            var result = this.manager.PinnedNotes(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            return this.NotFound();
        }

        /// <summary>
        /// to add the profile picture
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost, Route("profile")]
        public IActionResult ProfilePicture(IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = this.manager.AddImage(file);
                return this.Ok(new { ImagePath = path });
            }
            return this.BadRequest();
        }

        /// <summary>
        /// to add the Collaborator to the notes
        /// </summary>
        /// <param name="recieverEmail"></param>
        /// <param name="noteId"></param>
        /// <returns></returns>
        [HttpPost, Route("addcollab")]
        public IActionResult AddCollaborator([EmailAddress, Required]string recieverEmail, int noteId)
        {
            if (ModelState.IsValid)
            {
                string email;
                try
                {
                    email = User.Identity.Name;
                }
                catch
                {
                    email = null;
                }
                var collab = new CollaboratorModel
                {
                    NoteId = noteId,
                    RecieverEmail = recieverEmail,
                    SenderEmail = email
                };
                var result = this.manager.AddCollaboratorToNote(collab);
                if (result == 1)
                {
                    return this.Ok("Added");
                }
                return this.NotFound();
            }
            return this.BadRequest();
        }

        /// <summary>
        /// to remove the Collaborator
        /// </summary>
        /// <param name="noteId"></param>
        /// <param name="recieverEmail"></param>
        /// <returns></returns>
        [HttpPost, Route("removecollaborator")]
        public IActionResult RemoveCollaborator(int noteId, [EmailAddress, Required]string recieverEmail)
        {
            if (ModelState.IsValid)
            {
                string email;
                try
                {
                    email = User.Identity.Name;
                }
                catch
                {
                    email = null;
                }
                var collab = new CollaboratorModel
                {
                    NoteId = noteId,
                    SenderEmail = email,
                    RecieverEmail = recieverEmail
                };
                var result = this.manager.RemovecollaboratorFromNote(collab);
                if (result == 1)
                {
                    return this.Ok("Removed");
                }
                return this.NotFound();
            }
            return this.BadRequest();
        }
        [HttpGet, Route("getCollabnote")]
        public IActionResult GetCollabNotes()
        {
            string currentUser;
            try
            {
                currentUser = User.Identity.Name;
            }
            catch (Exception e)
            {
                currentUser = null;
            }
            var notes = this.manager.GetCollabNotes(currentUser);
            if (notes != null)
            {
                return this.Ok(notes);
            }
            return this.NotFound("There are no results for your query");
        }
        [HttpGet, Route("getnotelabels")]
        public async Task<IActionResult> GetNoteLabels(int id)
        {
            if (ModelState.IsValid)
            {
                string CurrentUser;
                try
                {
                    CurrentUser = this.User.Identity.Name;
                }
                catch(Exception e)
                {
                    CurrentUser = null;
                }
                var result = this.manager.GetNotLabels(id, CurrentUser);
                return this.Ok(result);
            }
            return this.NoContent();
        }
    }
}
