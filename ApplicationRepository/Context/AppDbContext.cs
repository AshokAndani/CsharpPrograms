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
    using Common.Models;
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

        /// <summary>
        /// Table for Labels in the Database
        /// </summary>
        public DbSet<LabelsModel> Labels { get; set; }

        /// <summary>
        /// table for Notes in the Database
        /// </summary>
        public DbSet<NotesModel> Notes { get; set; }
        
        /// <summary>
        /// table for Collaborators in the Database
        /// </summary>
        public DbSet<CollaboratorModel> Collaborators { get; set; }
    }
}
