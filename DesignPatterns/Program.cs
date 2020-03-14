// <copyright file="Program.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns
{
    using System;
    using DesignPatterns.Creational.SingletonPattern;
    using DesignPatterns.Creational.FactoryPattern;
    using DesignPatterns.Creational.PrototypeDesignPattern;
    using DesignPatterns.Structural.Adapter;
    using DesignPatterns.Structural.Facade;
    using DesignPatterns.Structural.Proxy;
    using DesignPatterns.Behavioral.Observer;
    using DesignPatterns.Behavioral.Visitor;
    using DesignPatterns.Behavioral.Visitor1;
    using DesignPatterns.Behavioral.Mediator;
    using DesignPatterns.AutoMapper;
    using DesignPatterns.Reflection;
    
    /// <summary>
    /// Entry Point class for CLR
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry Point Method for CLR
        /// </summary>
        /// <param name="args">void</param>
        public static void Main(string[] args)
        {
            //// asking for the required option
            Console.WriteLine("Enter 1 for Singleton Pattern\n" +
                "Enter 2 for Prototype Design Pattern\n" +
                "Enter 3 for Factory Design Pattern\n" +
                "Enter 4 for Adapter Design Pattern\n" +
                "Enter 5 for Facade Pattern\n" +
                "Enter 6 for Proxy Design Pattern\n" +
                "Enter 7 for Observer Design Pattern\n" +
                "Enter 8 for Vistor Design Patter\n" +
                "Enter 9 for Mediator Design Pattern\n" +
                "Enter 10 for AutomapManagement\n" +
                "Enter 11 for Late Binding Test\n" +
                "Enter 12 for testing Basic classes and methods of Reflection");

            int entered = int.Parse(Console.ReadLine());

            switch (entered)
            {
                case 0: 
                    break;
                case 1:
                    SingletonTest.DriverMethod();
                    break;
                case 2:
                    PrototypeTest.DriverMethod();
                    break;
                case 3:
                    TestFactory.DriverMethod();
                    break;
                case 4: new AdapterTest();   
                        break;
                case 5: FacadeTest.DriverMethod();
                    break;
                case 6: ProxyTest.DriverMethod();
                    break;
                case 7: ObserverTest.DriverMethod();
                    break;
                case 8: VistorPatternTest.DriverMethod();
                    break;
                case 9: MediatorTest.DriverMethod();
                    break;
                case 10: AutomapManagement.DriverMethod();
                    break;
                case 11: ReflectionTest.DriverMethod();
                    break;
                case 12: Basics.DriverMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}