// <copyright file="ObserverTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Observer
{
    using System;
    /// <summary>
    /// this class is used to run the test Observer Pattern
    /// </summary>
    public class ObserverTest
    {
        public static void DriverMethod()
        {
            Mobile redmi = new Mobile("Samsung");
            redmi.Attach(new CustomerImpl("ashok"));
            redmi.Attach(new CustomerImpl("Anil"));
            redmi.Attach(new CustomerImpl("ramesh"));
            redmi.Attach(new CustomerImpl("Shivaraj"));

            redmi.Availability = true;
        }
    }
}
