// <copyright file="Customer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexTypeToPrimitive
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is the class whose properties will be copied to the Employee Object
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer class Fields
        /// </summary>
        public string name;
        public Address address;

        /// <summary>
        /// Constructor to initialize the name of Customer 
        /// </summary>
        /// <param name="name"></param>
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
