// <copyright file="Mobile.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Observer
{
    using System;

    /// <summary>
    /// this class extends the Mobileshop which is created when the customer needs the mobile phone
    /// </summary>
    public class Mobile : MobileShop
    {
        /// <summary>
        /// constructor to initialize the model name
        /// </summary>
        /// <param name="model">Model name of Mobile</param>
        public Mobile(string model) : base(model)
        {
        }
    }
}


