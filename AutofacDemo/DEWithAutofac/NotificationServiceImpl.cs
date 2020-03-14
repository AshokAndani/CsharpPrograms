// <copyright file="NotificationServiceImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.DEWithAutofac
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class writes to console about the username change
    /// </summary>
    class NotificationServiceImpl : INotificationService
    {
        /// <summary>
        /// this method consists the logic to write to console
        /// </summary>
        /// <param name="user"></param>
        public void UserNameChanged(IUser user)
        {
            Console.WriteLine("Notification:   User name changed to "+user.UserName);
        }
    }
}
