// <copyright file="SQLUserRepo.cs" company="BridgeLabz">
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
    /// this class has the implementation of theIUserRepo and makes the CRUD operations directly to DB
    /// </summary>
    public class SQLUserRepo : IUserRepo
    {
        /// <summary>
        /// this is an instance of the database
        /// </summary>
        private UserContext context;

        /// <summary>
        /// injecting the Context onject through constructor
        /// </summary>
        /// <param name="context"></param>
        public SQLUserRepo(UserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// to add the User
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            context.users.Add(user);
            context.SaveChanges();
        }

        /// <summary>
        /// to delete the User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Delete(int id)
        {
            User user = context.users.Find(id);
            context.users.Remove(user);
            return user;
        }

        /// <summary>
        /// to fetch the particular user from the DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id)
        {
            return context.users.Find(id);
        }

        /// <summary>
        /// to get the multiple user form the DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUsers()
        {
            return context.users;
        }

        /// <summary>
        /// to update the existing User in DB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Update(User user)
        {
            //to update the user
            var usern = context.users.Attach(user);

            //this line keeps track on the changes and assign the changed value
            usern.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
            //to save the changes to the DB
            context.SaveChanges();
            
            //returns the changed user
            return user;
        }
    }
}
