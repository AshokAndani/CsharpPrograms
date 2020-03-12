// <copyright file="SingletonTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    using System.Threading.Tasks;
    class SingletonTest
    {
        public static void DriverMethod()
        {
            //// here testing for normal class
            Console.WriteLine("---------Normal class Fails for creating only 1 instance even in single thread Environment----------");
            NormalClass t1, t2;
            t1 = NormalClass.GetNormalClass();
            t2 = NormalClass.GetNormalClass();