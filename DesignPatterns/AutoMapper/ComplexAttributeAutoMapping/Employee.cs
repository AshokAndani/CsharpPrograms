// <copyright file="Employee.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexAttributeAutoMapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class fields are filled by the auto mapper
    /// </summary>
    public class Employee
    {
        internal string name;
        internal AddressDTO address;
        public override string ToString()
        {
            return string.Format("{0}-----------\nName: {1}\nAddress: {2}", this.GetType().Name, this.name, this.address);
        }
    }
}
