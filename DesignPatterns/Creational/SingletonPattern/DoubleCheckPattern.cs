// <copyright file="DoubleCheckPattern.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    /// <summary>
    ///  this class is totally thread safe which ensures double check locking
    ///  and creates only one instance of the class
    /// </summary> 
    public sealed class DoubleCheckPattern
    {
        //// this is to check how many instances are being created
        private static int count = 0;

        //// initializing the instance which will be initialized later
        private static DoubleCheckPattern instance = null;

        //// The Object which acts as a locker for threads entering to create the instance
        private static Object locker = new object();
