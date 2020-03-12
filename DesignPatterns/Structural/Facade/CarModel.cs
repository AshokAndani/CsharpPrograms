// <copyright file="CarModel.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Facade
{
    using System;

    /// <summary>
    /// this is the sub-system class for the car product
    /// </summary>
    public class CarModel
    {
        /// <summary>
        ///  this method is for getting the Model
        /// </summary>
        public void GetModel()
        {
            Console.WriteLine("Getting the Car Model");
        }
    }
}
