﻿/// <copyright file="StaticConstructorSingleton.cs" company="BridgeLabz">
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