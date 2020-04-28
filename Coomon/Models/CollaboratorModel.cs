// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorModel.cs" company="Bridgelabz">
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
    /// CollaboratorModel
    /// </summary>
    public class CollaboratorModel
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public string SenderEmail { get; set; }
        public string RecieverEmail { get; set; }
    }
}
