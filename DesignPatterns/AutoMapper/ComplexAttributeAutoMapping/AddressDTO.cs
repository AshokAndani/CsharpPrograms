// <copyright file="AddressDTO.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>


namespace DesignPatterns.AutoMapper.ComplexAttributeAutoMapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// simple address class holds the address of the peron
    /// </summary>
    class AddressDTO
    {
        public string HomeTown,
            Currentstate,
            country;


        public override string ToString()
        {
            return string.Format("(Inner class name){0}------\nHomeTown: {1}\tCurrentState: {2}\tNation: {3}\n", this.GetType().Name, this.HomeTown, this.Currentstate, this.country);
        }
    }
}
