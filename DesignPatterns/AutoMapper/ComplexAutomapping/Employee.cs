// <copyright file="Employee.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexAutomapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is mapped with the Customer class
    /// </summary>
    public class Employee
    {
        public string name;
        public AddressDTO address;

        public override string ToString()
        {
            return string.Format("{0}\nName: {1}\nAddress: {2}\n", this.GetType().Name, this.name, this.address);
        }
    }
}
