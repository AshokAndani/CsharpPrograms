// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Books.cs" company="Bridgelabz">
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
    /// Books Model
    /// </summary>
    public class Books
    {
        [Key]
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public string ContentType { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageContent { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }
    }
}
