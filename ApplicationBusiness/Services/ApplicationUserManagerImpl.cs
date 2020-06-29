// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationUserManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.ApplicationBusiness.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    /// <summary>
    /// to Manage the User Account
    /// </summary>
    public class ApplicationUserManagerImpl : IApplicationUserManager
    {
        private readonly IConfiguration configuration;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        /// <summary>
        /// tot inject IConfiguration
        /// </summary>
        /// <param name="configuration">configuration</param>
        /// <param name="userManager">userManager</param>
        /// <param name="signInManager">signInManager</param>
        public ApplicationUserManagerImpl(IConfiguration configuration, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.configuration = configuration;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        /// <summary>
        /// to create the user
        /// </summary>
        /// <param name="model">RegisterModel</param>
        /// <returns>result</returns>
        public async Task<IdentityResult> CreateUserAsync(RegisterViewModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            return await this.userManager.CreateAsync(user, model.Password);
        }

        /// <summary>
        /// to get the JWT token
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Token</returns>
        public string GetJwtToken(string email)
        {
            var claim = new[] { new Claim(JwtRegisteredClaimNames.UniqueName, email) };
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:_key"]));
            var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:_url"],
                audience: configuration["Jwt:_url"],
                claims: claim,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signInCr);
            var FinalToken = new JwtSecurityTokenHandler().WriteToken(token);
            return FinalToken;
        }

        /// <summary>
        /// to login the User
        /// </summary>
        /// <param name="model">LoginModel</param>
        /// <returns>result</returns>
        public async Task<SignInResult> LoginUserAsync(LoginViewModel model)
        {
            return await this.signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, false);
        }

        /// <summary>
        /// to change the Password
        /// </summary>
        /// <param name="model">ChangePasswordModel</param>
        /// <returns>result</returns>
        public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model)
        {
            var user = await this.userManager.FindByEmailAsync(model.Email);
            return await this.userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);
        }

        /// <summary>
        /// to log out the User
        /// </summary>
        public async void LogoutAsync()
        {
            await this.signInManager.SignOutAsync();
        }
    }
}
