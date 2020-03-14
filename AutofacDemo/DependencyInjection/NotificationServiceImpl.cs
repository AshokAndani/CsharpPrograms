// <copyright file="NotificationServiceImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.NotificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is to provide notification of username change
    /// </summary>
    public class NotificationServiceImpl : INotificationService
    {
        /// <summary>
        /// the methods which is used to find the username change
        /// </summary>
        /// <param name="user"></param>
        public void UserNameChanged(IUser user)
        {
            //// prints to console whenever the username is changed
            Console.WriteLine("Notification: username changed to : "+user.Username);
        }
    }
}
