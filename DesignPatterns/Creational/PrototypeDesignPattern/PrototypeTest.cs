// <copyright file="PrototypeTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    using System;
    /// <summary>
    ///  this class is used to manage the Prototype pattern classes
    /// </summary>
    class PrototypeTest
    {
        /// <summary>
        /// this is a simple static method used to run without creating its class Object
        /// </summary>
        public static void DriverMethod()
        {
            //// simulates the PersonShallowCopy class
            PersonShallowCopy originalShallow = new PersonShallowCopy();
            originalShallow.name = "Ashok";
            originalShallow.age = 23;
            originalShallow.address = new Address("Banglore", "Karnataka", "India");
