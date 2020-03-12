// <copyright file="NormalClass.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    /// <summary>
    ///  this class represents the normal classes which does not follow singleton pattern rules
    /// </summary>
    public class NormalClass
    {
        /// <summary>
        /// to count how many instances are created
        /// </summary>
        private static int count = 0;
