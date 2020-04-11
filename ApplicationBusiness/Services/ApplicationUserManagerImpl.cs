// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationUserManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ApplicationBusiness.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using ApplicationBusiness.Interfaces;
    using Common.Models;
    using Microsoft.AspNetCore.Identity;
    
    /// <summary>
    /// this class is the implementation of the IApplicationUserManager
    /// </summary>
    public class ApplicationUserManagerImpl : IApplicationUserManager
    {
        /// <summary>
        /// UserManager which manages the User Account
        /// </summary>
        private readonly UserManager<IdentityUser> userManager;
        
        /// <summary>
        /// SignInManager which Manages the Login And Logout of the users
        /// </summary>
        private readonly SignInManager<IdentityUser> signInManager;

        /// <summary>
        /// Constructor for injecting the UserManager and SignInManager
        /// </summary>
        /// <param name="userManager">Injects UserManager</param>
        /// <param name="signInManager">Injects SignInManager</param>
        public ApplicationUserManagerImpl(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        /// <summary>
        /// To Change the User Password
        /// </summary>
        /// <param name="model">supplied from body</param>
        /// <returns>Result</returns>
        public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model)
        {
            var user = await this.userManager.FindByEmailAsync(model.Email);
            return await this.userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);
        }

        /// <summary>
        /// Creates the New User
        /// </summary>
        /// <param name="model">Supplied from the body</param>
        /// <returns>Result</returns>
        public async Task<IdentityResult> CreateUserAsync(RegisterViewModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            return await this.userManager.CreateAsync(user, model.Password);
        }

        /// <summary>
        /// Generates the token for forgot password
        /// </summary>
        /// <param name="model">Supplied from body</param>
        /// <returns>Result</returns>
        public async Task<string> GetResetToken(ForgotPasswordModel model)
        {
            //// finfing the wether the user exists with Email
            var user = await this.userManager.FindByEmailAsync(model.Email);
            
            //// Checking if the Email is Comfirmed 
            if (await this.userManager.IsEmailConfirmedAsync(user))
            {
                var token = await this.userManager.GeneratePasswordResetTokenAsync(user);
                return token;
            }
            return null;
        }

        /// <summary>
        /// to login the User
        /// </summary>
        /// <param name="model">Supplied from body</param>
        /// <returns>Result</returns>
        public async Task<SignInResult> LoginUserAsync(LoginViewModel model)
        {
            return await this.signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, false);
        }

        /// <summary>
        /// to reset the password
        /// </summary>
        /// <param name="model">ResetPasswordModel</param>
        /// <returns>Result</returns>
        public async Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model)
        {
            var user = await this.userManager.FindByEmailAsync(model.Email);
            return await this.userManager.ResetPasswordAsync(user, model.Token, model.Password);
        }
    }
}
