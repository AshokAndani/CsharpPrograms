/// <copyright file="NaiveSingleton.cs" company="BridgeLabz">
///     BridgeLabz. All rights reserved.
/// </copyright>
/// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;

    /// <summary>
    ///  The class whose instance to be created only once
    ///  Not good in multi-thread Environment
    /// </summary>
    public sealed class NaiveSingleton
    {
        private static int count = 0;
        /// <summary>
        /// declaring the instance which will be assigned throw an static Method
        /// </summary>
        private static NaiveSingleton naive;

        /// <summary>
        ///  making the constructor as Private so that no-one can create its instance
        /// </summary>
        private NaiveSingleton()
        {
            //// this is to Notify how many times the constructor is called
            Console.WriteLine("Cunstructor of Naive Called " + ++count);
        }

        /// <summary>
        /// this is a public method which is responsible to create only one instance
        /// </summary>
        /// <returns>NaiveSingleton</returns>
        public static NaiveSingleton Instance
        {
            get
            {
                if (naive == null)
                {
                    naive = new NaiveSingleton();
                }
                return naive;
            }
        }
    }
}