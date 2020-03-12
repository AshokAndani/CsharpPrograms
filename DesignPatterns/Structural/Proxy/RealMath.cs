// <copyright file="RealMath.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Proxy
{
    using System;

    /// <summary>
    ///  this class is the real class or concrete class which contains source code
    /// </summary>
    public class RealMath : IMath
    {
        public double Add(double m, double n)
        {
            return m + n;
        }

        public double Division(double m, double n)
        {
            return m / n;
        }

        public double Multiplication(double m, double n)
        {
            return m * n;
        }

        public double Sub(double m, double n)
        {
            return m - n;
        }
    }
}
