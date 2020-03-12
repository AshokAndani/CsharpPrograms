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

            //// checking for NaiveSingleton in multi-thread Environment
            Console.WriteLine("------------Naive Pattern fails for 1 instance in multi-thread Environment-------------");
            NaiveSingleton n1, n2;
            Parallel.Invoke(
                () => n1 = NaiveSingleton.Instance,
                ()=> n2=NaiveSingleton.Instance
                ) ;
            //// checking for DoubleCheckPattern under multi-Thread Environment
            Console.WriteLine("------DuobleCheckpattern will not let anyone to create multiple instance even in multi-thread Environment-------");
            DoubleCheckPattern d1, d2;
            Parallel.Invoke(
                () => d1=DoubleCheckPattern.Instance,
                () => d2=DoubleCheckPattern.Instance
                );
        }
    }
}
