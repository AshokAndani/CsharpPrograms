// <copyright file="IUser.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo.DEWithAutofac
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this interface has a method to change the username
    /// </summary>
    interface IUser
    {
        /// <summary>
        /// username property
        /// </summary>
        public string UserName { get;  set; }

        /// <summary>
        /// method to change the username
        /// </summary>
        /// <param name="username"></param>
        public void ChangeUserName(string username);
    }
}
