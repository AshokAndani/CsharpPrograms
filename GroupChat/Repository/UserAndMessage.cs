// <copyright file="IMessageHandler.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Repository
{
    public class UserAndMessage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string  GroupName { get; set; }
        [Required]
        public string SocketID { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
