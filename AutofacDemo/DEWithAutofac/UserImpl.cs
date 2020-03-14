// <copyright file="UserImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.DEWithAutofac
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// this class is the one where username resides to operate on it
    /// </summary>
    class UserImpl : IUser
    {
        /// <summary>
        /// dependency object on which this class depends on
        /// </summary>
        private INotificationService service;

        /// <summary>
        /// constructor which takes the dependency object as parameter
        /// </summary>
        /// <param name="service">Service</param>
        public UserImpl(INotificationService service)
        {
            this.service = service;
        }