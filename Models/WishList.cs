// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WishList.cs" company="Bridgelabz">
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
    /// WishList Model
    /// </summary>
    public class WishList
    {
        [Key]
        public Guid WishListID { get; set; }
        public string UserName { get; set; }
        public Guid BookID { get; set; }
    }
}
