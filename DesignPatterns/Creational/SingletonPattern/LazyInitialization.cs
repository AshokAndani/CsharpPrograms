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
        /// <summary>
        /// Lazy initialization using the Lazy Type which is internally thread safe
        /// </summary>
        private static readonly Lazy<LazyInitialization> lazy = new Lazy<LazyInitialization>(() => new LazyInitialization());

        /// <summary>
        /// public varibale which returns the only one Instance 
        /// </summary>
        public static LazyInitialization Instance 
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
