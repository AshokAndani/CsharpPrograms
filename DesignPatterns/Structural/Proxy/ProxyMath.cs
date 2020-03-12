// <copyright file="ProxyMath.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Proxy
{
    using System;

    /// <summary>
    /// this is the proxy class which controls the accessiblity of the real concrete class
    /// </summary>
    public class ProxyMath : IMath
    {
        private RealMath realMath = new RealMath();
        public double Add(double m, double n)
        {
            return realMath.Add(m, n);
        }

        public double Division(double m, double n)
        {
            return realMath.Division(m, n);
        }

        public double Multiplication(double m, double n)
        {
            return realMath.Multiplication(m, n);
        }

        public double Sub(double m, double n)
        {
            return realMath.Sub(m, n);
        }
    }
}
