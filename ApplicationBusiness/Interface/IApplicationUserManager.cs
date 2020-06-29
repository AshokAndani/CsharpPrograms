// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplicationUserManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.ApplicationBusiness.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BookStore.Models;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// To Manager the User Account
    /// </summary>
    public interface IApplicationUserManager
    {
        /// <summary>
        /// Creates the new User
        /// </summary>
        /// <param name="model">Register Model</param>
        /// <returns>result</returns>
        Task<IdentityResult> CreateUserAsync(RegisterViewModel model);

        /// <summary>
        /// to login the user
        /// </summary>
        /// <param name="model">LoginModel</param>
        /// <returns>result</returns>
        Task<SignInResult> LoginUserAsync(LoginViewModel model);

        /// <summary>
        /// to get the JWT token after Login
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>string token</returns>
        string GetJwtToken(string email);

        /// <summary>
        /// to logout the logged in user
        /// </summary>
        void LogoutAsync();

        /// <summary>
        /// to change the password
        /// </summary>
        /// <param name="model">ChangePassword Model</param>
        /// <returns>result</returns>
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
    }
}
