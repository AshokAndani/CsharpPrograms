// <copyright file="Computer.cs" company="BridgeLabz">
//     BridgeLabz. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.FactoryPattern
{
    using System;

    /// <summary>
    ///  this is the abstract class which has some abstract methods
    /// </summary>
    public abstract class Computer
    {
        public abstract string GetRAM();

        public abstract string GetHDD();

        public abstract string GetCPU();

        /// <summary>
        /// overridden ToString () to represent the Object state to string format
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "RAM capacity is = " + this.GetRAM() + "   CPU =   " + this.GetCPU() + "  HDD capacity is = " + this.GetHDD();
        }
    }
}
