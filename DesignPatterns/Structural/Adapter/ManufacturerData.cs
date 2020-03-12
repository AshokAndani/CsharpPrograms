// <copyright file="ManufacturerData.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Adapter
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// holds the information about multiple manufacturers
    /// </summary>
    class ManufacturerData
    {
        /// <summary>
        ///  this method return the the list of Manufacturers
        /// </summary>
        /// <returns>List of Manufacturers</returns>
        public static List<Manufacturer> GetManufacturers() =>
            //// used lambda expression for writing the methods
            new List<Manufacturer>
            { new Manufacturer{ name = "ashok", place = "banlgore" },
                new Manufacturer{ name = "harish", place = "Pune" }
            };
    }
}
