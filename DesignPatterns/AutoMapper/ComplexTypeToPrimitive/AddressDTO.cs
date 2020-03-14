// <copyright file="AddressDTO.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexTypeToPrimitive
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class holds the address info of Employee Object
    /// </summary>
    public class AddressDTO
    {
        /// <summary>
        /// Address fields
        /// </summary>
        public string HomeTown,
            Currentstate,
            country;

        public override string ToString()
        {
            return string.Format("(Inner class name){0}------\nHomeTown: {1}\tCurrentState: {2}\tNation: {3}\n", this.GetType().Name, this.HomeTown, this.Currentstate, this.country);
        }
    }
}
