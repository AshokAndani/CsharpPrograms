// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CartTable.cs" company="Bridgelabz">
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
    /// CartTable
    /// </summary>
    public class CartTable
    {
        [Key]
        public int ID { get; set; }
        public Guid BookID { get; set; }
        public string UserName { get; set; }
    }
}
