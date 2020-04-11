// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDbContext.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationRepository.Context
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    
    /// <summary>
    /// Extended class of IdentitDbContext
    /// </summary>
    public class AppDbContext : IdentityDbContext
    {
        /// <summary>
        /// Calling the Super Class Constructor by passing the Parameter
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
    }
}
