// <copyright file="IUser.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>


namespace AutofacDemo.NotificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  methods for user
    /// </summary>
    public interface IUser
    {
        public string Username { get; set; }

        /// <summary>
        /// this method is to change the username field
        /// </summary>
        /// <param name="username">string username</param>
        public void ChangeUserName(string username);
    }
}
