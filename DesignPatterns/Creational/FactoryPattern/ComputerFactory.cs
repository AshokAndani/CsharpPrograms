// <copyright file="ComputerFactory.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.FactoryPattern
{
    using System;

    /// <summary>
    ///  the class which is responsible to decide which class to be invoked based on type input
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// this is the main static factory method that binds the Objects on type
        /// </summary>
        /// <param name="type">the classname</param>
        /// <param name="cpu">cpu type</param>
        /// <param name="hdd">hdd capacity</param>
        /// <param name="ram">ram size</param>
        /// <returns></returns>
        public static Computer GetComputer(string type, string cpu, string hdd, string ram)
        {
            if (type.Equals("PC"))
            {
                return new PC(cpu, hdd, ram);
            }
            else if (type.Equals("Server"))
            {
                return new Server(cpu, hdd, ram);
            }
            else Console.WriteLine("Given class not found");
            return null;
        }
    }
}
