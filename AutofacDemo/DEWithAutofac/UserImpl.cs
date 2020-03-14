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
        /// <summary>
        /// username set to private so it cannot be accessed other than this class
        /// </summary>
        private string userName;

        /// <summary>
        /// username can only be accessed through this property
        /// </summary>
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                if (this.userName == null)
                {
                    this.userName = value;
                }
            }
        }

        /// <summary>
        /// to change the username
        /// </summary>
        /// <param name="username"></param>
        public void ChangeUserName(string username)
        {
            this.userName = username;

            //// dependency object's method 
            service.UserNameChanged(this);
        }
    }
}
