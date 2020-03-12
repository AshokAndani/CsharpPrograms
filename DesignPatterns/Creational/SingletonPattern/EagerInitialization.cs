// <copyright file="EagerInitialization.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    public sealed class EagerInitialization
    {
        //// this is to check how many times the Constructor is called
        private static int count = 0;