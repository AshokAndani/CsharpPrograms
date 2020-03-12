// <copyright file="Address.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    using System;	
    /// <summary>
    ///  Address class will be used to store information of a person in nested form
    /// </summary>
    public class Address : ICloneable
    {
        public string city;
        public string state;
        public string Country;
        public Address(string city, string state, string country)
        {
            this.city = city;
            this.state = state;
            this.Country = country;
       }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return string.Format("City: {0}\t\tState: {1}\tCountry: {2}\n", this.city, this.state, this.Country);

        }
    }
}
