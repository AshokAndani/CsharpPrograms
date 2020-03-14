// <copyright file="Employee.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.ComplexTypeToPrimitive
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class will be mapped by mapper with the Customer class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Fields about the Employee
        /// </summary>
        public string name, City, State, Country;

        /// <summary>
        /// to represent the Object to string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}-----------\nName: {1}\nCity: {2}\nState: {3}\nCountry: {4}", this.GetType().Name, this.name, this.City, this.State, this.Country);
        }
    }
}
