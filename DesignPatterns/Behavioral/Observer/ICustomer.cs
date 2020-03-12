// <copyright file="ICustomer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Observer
{
    using System;

    /// <summary>
    ///  this is the interface which has to be implemented
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// update method for the customers
        /// </summary>
        /// <param name="shop">about the Mobile availablity</param>
         void Update(MobileShop shop);
    }
}
