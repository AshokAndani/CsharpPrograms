// <copyright file="Server.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.FactoryPattern
{
    using System;

    /// <summary>
    ///  Server class which implements the Computer
    /// </summary>
    class Server : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;
        public Server(string cpu, string hdd, string ram)
        {
            this.cpu = cpu;
            this.hdd = hdd;
            this.ram = ram;
        }

        public override string GetCPU()
        {
            return this.cpu;
        }
        public override string GetHDD()
        {
            return this.hdd;
        }
        public override string GetRAM()
        {
            return this.ram;
        }
    }
}
