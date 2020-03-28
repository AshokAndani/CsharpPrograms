// <copyright file="IUSerRepo.cs" company="BridgeLabz">
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
    /// this interface contains the methods for CRUD operations
    /// </summary>
    public interface IUserRepo
    {
        /// <summary>
        /// to Add the User
        /// </summary>
        /// <param name="user"></param>
        void Add(User user);

        /// <summary>
        /// to Get the list of Users
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetUsers();

        /// <summary>
        /// to get the User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUser(int id);

        /// <summary>
        /// to Delete the User form the inventory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User Delete(int id);

        /// <summary>
        /// to update the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        User Update(User user);
    }
}
