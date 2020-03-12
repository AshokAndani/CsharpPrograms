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

        public MobileShop(string model)
        {
            this.model = model;
        }
        /// <summary>
        /// this method is for checking the availablity of the mobiles
        /// </summary>
        public bool Availability
        {
            get
            {
                return this.avaialblity;
            }
            set
            {
                if (this.avaialblity != value)
                {
                    this.avaialblity = value;
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// to add the customers  to the List to get notified
        /// </summary>
        /// <param name="customer"></param>
        public void Attach(CustomerImpl customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// to remove the customers who don't need the Notifications
        /// </summary>
        /// <param name="customer"></param>
        public void Remove(CustomerImpl customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// this method is to notify the customers 
        /// </summary>
        public void Notify()
        {
            foreach (CustomerImpl customer in this.customers)
            {
                customer.Update(this);
            }
        }

      
    }
}
