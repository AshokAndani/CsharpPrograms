// <copyright file="Customer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexAttributeAutoMapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this class the Customer class which has to fill the Employee Object fields
    /// </summary>
    public class Customer
    {
        public string name;
        public Address address;
        public Customer(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return string.Format("{0}-----------\nName: {1}\nAddress: {2}", this.GetType().Name, this.name, this.address);
        }
    }
}
