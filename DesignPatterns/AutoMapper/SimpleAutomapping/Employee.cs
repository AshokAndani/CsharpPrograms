// <copyright file="Employee.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.SimpleAutomapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is the Mapping the class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// some fields example
        /// </summary>
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;

        /// <summary>
        /// string representation object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("FirstName: {0}\nLastName: {1}\nAge: {2}\nCity: {3}", this.FirstName, this.LastName, this.Age, this.City);
        }
    }
}
