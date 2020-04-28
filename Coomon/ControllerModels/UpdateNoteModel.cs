// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateNoteModel.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.ControllerModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UpdateNoteModel
    /// </summary>
    public class UpdateNoteModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public string Reminder { get; set; }
    }
}
