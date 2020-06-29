// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressTable.cs" company="Bridgelabz">
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
    /// AddressTable
    /// </summary>
    public class AddressTable
    {
        [Key]
        public Guid AddressID { get; set; }
        public string AccountUserName { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string PinCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string LocalAddress { get; set; }
    }
}
