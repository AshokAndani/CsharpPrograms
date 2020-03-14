// <copyright file="INotificationService.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.DEWithAutofac
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this interface declared a usernamechange notification method
    /// </summary>
    interface INotificationService
    {
        /// <summary>
        /// to notify the username change
        /// </summary>
        /// <param name="user"></param>
        void UserNameChanged(IUser user);
    }
}
