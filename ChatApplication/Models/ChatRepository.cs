// <copyright file="ChatRepository.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class is a repository classs which has the methods to save the message to the database
    /// </summary>
    public class ChatRepository
    {
        private readonly DataDbContext context;

        /// <summary>
        /// This method is used to inject the Context iinherited class object
        /// </summary>
        /// <param name="context"></param>
        public ChatRepository(DataDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// this method adds the user object details to the Database
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            context.Add(user);
        }

        /// <summary>
        /// this method gets all the messages and usernames from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUsers()
        {
            return context.users;
        }
    }
}
