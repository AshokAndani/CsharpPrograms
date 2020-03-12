// <copyright file="TestFactory.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.FactoryPattern
{
    using System;

    /// <summary>
    ///  TestFactory class for testing the Factory method
    /// </summary>
    public class TestFactory
    {
        /// <summary>
        /// to run the code without creating the object of this class
        /// </summary>
        public static void DriverMethod()
        {
            //// this variable has the example for generating the PC object as the type is PC
            Computer pc = ComputerFactory.GetComputer("PC", "Intel iCore", "128GB", "8GB");
            Console.WriteLine(pc);
            Console.WriteLine(pc.GetType());

            //// this variable has the example for generating the Server Object as the type is Server
            Computer server = ComputerFactory.GetComputer("Server", "AMD Processor", "2TB", "8GB");
            Console.WriteLine(server);
            Console.WriteLine(server.GetType());

            //// this variable has the example which prints class not found type doesn't exists
            Computer Foo = ComputerFactory.GetComputer("Foo", "RADEON", "1TB", "4GB");
            Console.WriteLine(Foo);
        }
    }
}
