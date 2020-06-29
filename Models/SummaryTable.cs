// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SummaryTable.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// SummaryTable
    /// </summary>
    public class SummaryTable
    {
        [Key]
        public int ID { get; set; }
        public string AccountUserName { get; set; }
        public Guid BookID { get; set; }
        public Guid AddressID { get; set; }
    }
}
