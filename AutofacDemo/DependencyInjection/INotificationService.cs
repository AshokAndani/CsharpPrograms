// <copyright file="INotificationService.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.NotificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// inteeface for Notification
    /// </summary>
    interface INotificationService
    {
        /// <summary>
        /// to notify username change
        /// </summary>
        /// <param name="user"></param>
        public void UserNameChanged(IUser user);
    }
}
