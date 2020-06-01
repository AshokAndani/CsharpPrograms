// <copyright file="User.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// this is the user class which is to be added to the list
    /// </summary>
    public class User
    {
        [Key, Display(Name="Identity:")]
        public int ID { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="Invalid Entry"), MaxLength(30),Display(Name ="Name: ")]
        public string Name { get; set; }
        [Required, EmailAddress,Display(Name ="Email Address: ")]
        public string  Email { get; set; }
    }
}
