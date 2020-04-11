// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplicationUserManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationBusiness.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Models;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// this interface provides the methods to manage the application users
    /// </summary>
    public interface IApplicationUserManager
    {
        /// <summary>
        /// to create the new Users
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IdentityResult> CreateUserAsync(RegisterViewModel model);

        /// <summary>
        /// loggig in the User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<SignInResult> LoginUserAsync(LoginViewModel model);
        
        /// <summary>
        /// Generates the token against the user who forgot the password
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<string> GetResetToken(ForgotPasswordModel model);

        /// <summary>
        /// Resets the Password based on the token
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
        
        /// <summary>
        /// Changes the password when a user wants to change the Password
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
    }
}
