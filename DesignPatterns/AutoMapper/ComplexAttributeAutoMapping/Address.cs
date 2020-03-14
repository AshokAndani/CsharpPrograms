// <copyright file="Address.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexAttributeAutoMapping
{
    using System;

    /// <summary>
    /// class which holds address of a person
    /// </summary>
    public class Address
    {
        public string city, state, country;

        /// <summary>
        /// pareameterized constructor to fill the attributes
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

        /// <summary>
        /// to string to represent in string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("(Inner class Name){0}------\nCity: {1}\tState: {2}\tCountry: {3}\n", this.GetType().Name, this.city, this.state, this.country);
        }
    }
}
