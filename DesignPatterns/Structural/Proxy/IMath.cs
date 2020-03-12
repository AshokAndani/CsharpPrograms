// <copyright file="IMath.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Proxy
{
    using System;

    /// <summary>
    /// interface which provides few methods to be implemented
    /// </summary>
    public interface IMath
    {
        public double Add(double m, double n);
        public double Sub(double m, double n);
        public double Multiplication(double m, double n);
        public double Division(double m, double n);
    }
}
