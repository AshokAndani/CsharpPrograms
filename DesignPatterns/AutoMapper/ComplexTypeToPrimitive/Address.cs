// <copyright file="Address.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexTypeToPrimitive
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class holds the information of the Person
    /// </summary>
    public class Address
    {
        public string city, state, country;


        /// <summary>
        /// constructor to initialize the fields
        /// </summary>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        public Address(string city, string state, string country)
        {
            this.city = city;
            this.state = state;
            this.country = country;
        }
        public override string ToString()
        {
            return string.Format("(Inner class Name){0}------\nCity: {1}\tState: {2}\tCountry: {3}\n", this.GetType().Name, this.city, this.state, this.country);
        }
    }
}
