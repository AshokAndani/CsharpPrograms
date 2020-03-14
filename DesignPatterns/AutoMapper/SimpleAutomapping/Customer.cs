// <copyright file="Customer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.SimpleAutomapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer
    {
        /// <summary>
        /// some fields for examples
        /// </summary>
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;

        /// <summary>
        /// param constructor for initializing the fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        public Customer(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        /// <summary>
        /// string representation of Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("FirstName: {0}\nLastName: {1}\nAge: {2}\nCity: {3}", this.FirstName,this.LastName,this.Age,this.City);
        }
    }
}
