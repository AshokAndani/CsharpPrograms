/// <copyright file="EagerInitialization.cs" company="BridgeLabz">
///     BridgeLabz. All rights reserved.
/// </copyright>
/// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    using System.Text;
    public sealed class EagerInitialization
    {
        //// this is to check how many times the Constructor is called
        private static int count = 0;

        /// <summary>
        /// private that no one can call this constructor and create the instance of this class
        /// and this is thread safe only in C# because CLR takes care of Thread accessing the instances
        /// </summary>
        private EagerInitialization()
        {
            //// to check the Object created or not
            Console.WriteLine("Eager Pattern is created " + ++count);
        }

        //// creating a static instance 
        private static readonly EagerInitialization eager = new EagerInitialization();

        /// <summary>
        /// public static method which return the EagerPattern object
        /// </summary>
        /// <returns>EagerObject</returns>
        public static EagerInitialization GetEagerPattern()
        {
            return eager;
        }
    }
}
