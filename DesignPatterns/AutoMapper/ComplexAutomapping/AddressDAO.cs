// <copyright file="AddressDAO.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>


namespace DesignPatterns.AutoMapper.ComplexAutomapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  this class holds the address info of the Person
    /// </summary>
    public class AddressDAO
    {
        public string city, state, country;

        public AddressDAO(string city, string state, string country)
        {
            this.city = city;
            this.state = state;
            this.country = country;
        }
        public override string ToString()
        {
            return string.Format("{0}------\nCity: {1}\tState: {2}\tCountry: {3}\n", this.GetType().Name, this.city, this.state, this.country);
        }
    }
}
