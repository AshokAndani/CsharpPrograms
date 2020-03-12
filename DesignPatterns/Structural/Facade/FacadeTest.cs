// <copyright file="FacadeTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Facade
{
    using System;
    /// <summary>
    /// this is the interface which is used by the user to get the things done without thinking about complexity of sub-systems
    /// </summary>
    public class FacadeTest
    {
        /// <summary>
        ///  this is a simple static method which is used to run without creating this class
        /// </summary>
       public static void DriverMethod()
        {
            //// this is the client interface which client will use just by creating the Facade class Object
            Facade facade = new Facade();
            Console.WriteLine("the parts required for making a car");
            //// just by calling the Facade Mathod the car having different subsystem of class with thier methods are invoked
            ////using the Facade class
            facade.MakeCar();
        }
    }
}
