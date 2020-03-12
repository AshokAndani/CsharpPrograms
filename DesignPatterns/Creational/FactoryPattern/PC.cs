// <copyright file="PC.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.FactoryPattern
{
using System;

    internal class PC : Computer
    {    
	private string cpu;
        private string hdd;
        private string ram;
        public PC(string cpu, string hdd, string ram)
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
