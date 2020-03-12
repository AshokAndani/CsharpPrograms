// <copyright file="PersonShallowCopy.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    using System;

    /// <summary>
    /// this class simulates the example for shallow cloning where change in clone effects the original copy
    /// </summary>
    public class PersonShallowCopy : ICloneable
    {

        public string name;
        public int age;
        public Address address;

        /// <summary>
        /// overridden the clone() from ICloneable
        /// </summary>
        /// <returns>copy of the Object</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }