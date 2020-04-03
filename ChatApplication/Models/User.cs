// <copyright file="User.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class takes the message and the username and saves that to Database
    /// </summary>
    public class User
    {
        [Key]
        public int Id{ get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}
