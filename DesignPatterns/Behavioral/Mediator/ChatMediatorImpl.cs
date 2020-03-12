// <copyright file="ChatMediatorImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Mediator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this class is the implementation of IChatMediator where the required code for mediating is written
    /// </summary>
    public class ChatMediatorImpl : IChatMediator
    {
        /// <summary>
        /// to store the user objects were one object contact another 
        /// </summary>
        private List<User> users;

        /// <summary>
        /// constructor for initializing the list Object
        /// </summary>
        public ChatMediatorImpl()
        {
            users = new List<User>();
        }

        /// <summary>
        /// method to add Objects to the List
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// this method is an example for processing the information
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="user"></param>
        public void SendMessage(string msg, User user)
        {
            foreach (User u in users )
            {
                if(u != user)
                {
                    u.Recieve(msg);
                }
            }
        }
    }
}
