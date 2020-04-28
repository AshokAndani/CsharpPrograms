// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelsModel.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// this class represents the model for labels operation
    /// </summary>
    public class LabelsModel
    {
        [Key,]
        public int Id { get; set; }
        [Required]
        public string Label { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [ForeignKey("NotesLabelModel")]
        public int NoteId { get; set; }
    }
}
