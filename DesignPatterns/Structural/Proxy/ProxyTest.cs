// <copyright file="ProxyTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Proxy
{
    using System;

    /// <summary>
    /// this class is used to test the Proxy design Pattern
    /// </summary>
    public  class ProxyTest
    {
        /// <summary>
        /// simple static method to run without creating this class object
        /// </summary>
        public static void DriverMethod()
        {
            ProxyMath proxyMath = new ProxyMath();
            Console.WriteLine(proxyMath.Add(1, 3)) ;
        }
    }
}
