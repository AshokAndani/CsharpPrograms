// <copyright file="MobileShop.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Observer
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// the mobile class which is used to process the List of customers
    /// </summary>
    public class MobileShop
    {
        public string model;
        private bool avaialblity;
        private List<CustomerImpl> customers = new List<CustomerImpl>();