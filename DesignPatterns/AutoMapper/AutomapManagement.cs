// <copyright file="AutomapManagement.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DesignPatterns.AutoMapper.SimpleAutomapping;
    using DesignPatterns.AutoMapper.Mid_Automapping;
    using DesignPatterns.AutoMapper.ComplexAutomapping;
    using DesignPatterns.AutoMapper.ComplexAttributeAutoMapping;
    using DesignPatterns.AutoMapper.ComplexTypeToPrimitive;
    
    /// <summary>
    /// to run all the mapping tests
    /// </summary>
    public class AutomapManagement
    {
        /// <summary>
        /// static method to run the test
        /// </summary>
        public static void DriverMethod()
        {
            Console.WriteLine("Enter 1 for Simple Automapper Test\n" +
                "Enter 2 for Mid-Automapper Test\n" +
                "Enter 3 for Complex Test\n" +
                "Enter 4 for Complex Attribute Test\n" +
                "Enter 5 for Complex To Primitive Test\n");
            int entered = int.Parse(Console.ReadLine());

            switch (entered)
            {
                case 1:
                    SimpleTest.DriverMethod();
                    break;
                case 2:
                    MidTest.DriverMethod();
                    break;
                case 3:
                    ComplexTest.DriverMethod();
                    break;
                case 4:
                    ComplexAttributeTest.DriverMethod();
                    break;
                case 5:
                    ToPrimitiveTest.DriverMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
