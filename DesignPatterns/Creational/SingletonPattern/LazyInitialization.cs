/// <copyright file="LazyInitialization.cs" company="BridgeLabz">
///     BridgeLabz. All rights reserved.
/// </copyright>
/// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.SingletonPattern
{
    using System;
    /// <summary>
    /// Lazy initialization using the Lazy type provided by C#
    /// </summary>
    public sealed class LazyInitialization
    {

        /// <summary>
        /// making the constructor Private so that no one invoke this class instance
        /// </summary>
        private LazyInitialization()
        { }