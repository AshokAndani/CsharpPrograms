// <copyright file="Customer.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Observer
{
    using System;
/// <summary>
    ///  this class represents the customers who needs to get notified when the Mobile Phones are available
    /// </summary>
    public class CustomerImpl : ICustomer
    {	
    /// <summary>
        /// Customer name
        /// </summary>
        private string name;

        /// <summary>
        ///  initializing the Customer name using the Constructor
        /// </summary>
        /// <param name="name"></param>
        public CustomerImpl(string name)
        {
            this.name = name;
        }