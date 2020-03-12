// <copyright file="PersonDeepCopy.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    using System;

    /// <summary>
    ///  this class simulates the example for successfull nested cloning
    /// </summary>
    public class PersonDeepCopy : PersonShallowCopy
    {

        /// <summary>
        /// this is the overriden method from the ICloneable to clone the Objects
        /// </summary>
        /// <returns></returns>
        public new object Clone()
        {
            PersonDeepCopy deep = (PersonDeepCopy)this.MemberwiseClone();
            deep.address = (Address)this.address.Clone();
            return deep;
        }
    }
}
