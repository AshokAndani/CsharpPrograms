// <copyright file="UserRepo.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class implements the IUserRepo which actually used to store the data in the runtime
    /// </summary>
    public class UserRepo : IUserRepo
    {
        private List<User> users;

        /// <summary>
        /// initailizing the list with some example users in constructor
        /// </summary>
        public UserRepo()
        {
            this.users = new List<User>()
            {
                new User(){ID=1,Name="ashok",Email="Ashok@gmail.com",},
                new User(){ID=2,Name="Pavan",Email="Pavan@gmail.com",},
                new User(){ID=3,Name="Shivaraj",Email="Shivaraj@gmail.com",}
            };
        }

        /// <summary>
        /// to add the new user
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            users.Add(user);
        }

        /// <summary>
        /// to delete the User 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Delete(int id)
        {
            var user = users.FirstOrDefault(o => o.ID == id);
            users.Remove(user);
            return user;
        }

        /// <summary>
        /// to get the user based on the Id parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id)
        {
            var user = this.users.FirstOrDefault(o => o.ID == id);
            return user;
        }

        /// <summary>
        /// to get the list of users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUsers()
        {
            return this.users;
        }

        /// <summary>
        /// to update the existing user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Update(User user)
        {
            return user;
        }
    }
}
