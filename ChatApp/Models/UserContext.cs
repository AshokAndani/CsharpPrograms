// <copyright file="UserContext.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApp.Models
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class is the instance of the DatabaseContext
    /// </summary>
    public class UserContext : IdentityDbContext
    {
        /// <summary>
        /// to supply argument for base class constructor
        /// </summary>
        /// <param name="options"></param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        /// <summary>
        /// adding the user list to the Database
        /// </summary>
        public DbSet<User> users { get; set; }
    }
}
