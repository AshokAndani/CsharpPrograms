// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddNoteModel.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.ControllerModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    
    /// <summary>
    /// To Add the note NoteModel
    /// </summary>
    public class AddNoteModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public string Reminder { get; set; }
    }
}
