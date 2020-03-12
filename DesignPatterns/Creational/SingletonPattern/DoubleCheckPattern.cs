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