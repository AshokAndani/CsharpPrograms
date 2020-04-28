// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesLabelModel.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// NotesLabelModel
    /// </summary>
    public class NotesLabelModel
    {
        public int Id { get; set; }
        public int LabelId { get; set; }
        public int NoteId { get; set; }
    }
}
