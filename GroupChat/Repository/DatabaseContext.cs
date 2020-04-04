// <copyright file="DatabaseContext.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace GroupChat.Repository
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// this class contains the database operations
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// constructor calling the base class constructor which takes parameter
        /// </summary>
        /// <param name="options"></param>
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        /// <summary>
        /// creating the MessagesTb which resembles the database table
        /// </summary>
        public DbSet<UserAndMessage> MessagesTb { get; set; }
    }
}
