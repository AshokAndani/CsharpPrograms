// <copyright file="UserImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.NotificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// implements the IUser interface
    /// </summary>
    public class UserImpl : IUser
    {
        public string Username { get; set; }
        
        /// <summary>
        /// dependency Object on which IUser depends on
        /// </summary>
        private INotificationService service;

        /// <summary>
        /// using the constructor injection to inject the Object 
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="service">Object of InotificationImpl</param>
        UserImpl(string username, INotificationService service)
        {
            this.Username = username;

            //// Explicit Constructor injection
            this.service = service;
        }

        /// <summary>
        /// this method is used to change the username
        /// </summary>
        /// <param name="username"></param>
        public void ChangeUserName(string username)
        {
            this.Username = username;
            //// calling the method of dependency Object
            service.UserNameChanged(this);
        }
    }
}
