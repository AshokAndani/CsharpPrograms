/// <copyright file="SingleLockPattern.cs" company="BridgeLabz">
///     BridgeLabz. All rights reserved.
/// </copyright>
/// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    using System.Threading;
    
    /// <summary>
    ///  this is class contains the logic to make it totally thread safe but the Performance will be Very slow
    ///  as everytime the thread has to check for lock and to take out the lock on the Object(which is used as a locker).
    /// </summary>
    public sealed class SingleCheckPattern
    {
        //// this is to check how many times the Constructor is called
        private int count = 0;

        //// this object is used as Locker to keep ensure only one thread should attempt to create the instance at a time
        private static Object locker = new object();

        //// declaring the variable to initialize through the public Instance Variable
        private static SingleCheckPattern instance = null;

        /// <summary>
        ///  private constructor so that no one can create the instance of this class 
        /// </summary>
        private SingleCheckPattern()
        {
            Console.WriteLine("this is the "+ ++count +" Object");
        }

        /// <summary>
        ///  single-locking logic where the Instance is created only if the instance is null
        /// </summary>
        public static SingleCheckPattern Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                       instance = new SingleCheckPattern();
                    }
                    return instance;
                }
            }
        }
    }
}
