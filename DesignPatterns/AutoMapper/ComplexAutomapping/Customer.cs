// <copyright file="Customer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexAutomapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// this is the Class which will be Mapped with the another class having the fields
    /// </summary>
    public class Customer
    {
        public string name;
        public AddressDAO address;

        /// <summary>
        /// constructor having the name parameter
        /// </summary>
        /// <param name="name"></param>
        public Customer(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}\nName: {1}\nAddress: {2}\n", this.GetType().Name, this.name, this.address);
        }
    }
}
