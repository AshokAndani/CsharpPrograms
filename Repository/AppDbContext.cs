// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDbContext.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// AppDbContext
    /// </summary>
    public class AppDbContext : IdentityDbContext
    {
        /// <summary>
        /// Calling the Super Class Constructor by passing the Parameter
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<CartTable> CartTable { get; set; }
        public DbSet<SummaryTable> SummaryTable { get; set; }
        public DbSet<AddressTable> AddressTable { get; set; }
        public DbSet<WishList> WishList { get; set; }
    }
}
