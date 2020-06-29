// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisplayBook.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// DisplayBook Model
    /// </summary>
    public class DisplayBook
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public FileContentResult ImageFile { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }
    }
}
