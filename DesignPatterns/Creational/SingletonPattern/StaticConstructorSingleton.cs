/// <copyright file="StaticConstructorSingleton.cs" company="BridgeLabz">
///     BridgeLabz. All rights reserved.
/// </copyright>
/// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    /// <summary>
    ///  by using the static constructor  which will make the class execute only once 
    /// </summary>
    public sealed  class StaticConstructorSingleton
    {
        //// this variable is to initialize with one instance which will be returned by the public method
        private static readonly StaticConstructorSingleton instance = new StaticConstructorSingleton();

        /// <summary>
        ///  declaring the constructor as static
        /// </summary>
        static StaticConstructorSingleton()
        { }
        /// <summary>
        /// making the constructor private so that no one should access this class
        /// </summary>
        private StaticConstructorSingleton()
        { }

        /// <summary>
        ///  Gives the Instance
        /// </summary>
        public static StaticConstructorSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
