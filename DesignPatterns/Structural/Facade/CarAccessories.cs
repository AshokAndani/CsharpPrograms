// <copyright file="CarAccessories.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Facade
{
    using System;

    /// <summary>
    ///  this class is a sub-system class for the car Product
    /// </summary>
    public class CarAccessories
    {
        /// <summary>
        ///  method for getting the Car Accessories
        /// </summary>
        public void GetAccessories()
        {
            Console.WriteLine("Getting the Accessories");
        }
    }
}

