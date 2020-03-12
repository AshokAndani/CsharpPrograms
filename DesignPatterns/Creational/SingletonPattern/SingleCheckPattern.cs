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