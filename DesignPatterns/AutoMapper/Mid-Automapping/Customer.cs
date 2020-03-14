// <copyright file="Customer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.Mid_Automapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class will be mapped with the Employee class
    /// </summary>
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;

        public Customer(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        /// <summary>
        /// to represent string format of this class object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{4}------->\nFirstName: {0}\nLastName: {1}\nAge: {2}\nCity: {3}", this.FirstName, this.LastName, this.Age, this.City, this.GetType().Name);
        }
    }
}
