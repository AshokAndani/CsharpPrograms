// <copyright file="CarEngine.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Facade
{
    using System;

    /// <summary>
    ///  this class is the sub-system class for car product
    /// </summary>
    public class CarEngine
    {
        /// <summary>
        ///  this method is for getting the car Engine 
        /// </summary>
        public void GetEngine()
        {
            Console.WriteLine("Getting the Engine");
        }
    }
}
