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
