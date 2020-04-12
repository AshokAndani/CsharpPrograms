// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ApplicationBusiness.Interfaces;
    using Common.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Distributed;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    /// <summary>
    /// Annotation for Routing
    /// </summary>
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        /// <summary>
        /// IApplicationUserManager has the methods to manage the Application Users
        /// </summary>
        private readonly IApplicationUserManager manager;
        private readonly IConfiguration configuration;
        private readonly IDistributedCache distributedCache;

        /// <summary>
        /// Injecting the IAppliactionUserManager in Constructor
        /// </summary>
        /// <param name="manager">Provides the implemented object</param>
        public AccountController(IApplicationUserManager manager, IConfiguration configuration, IDistributedCache distributedCache)
        {
            this.manager = manager;
            this.configuration = configuration;
            this.distributedCache = distributedCache;
        }

        /// <summary>
        /// Registers the User
        /// </summary>
        /// <param name="model">Gets from the Body</param>
        /// <returns>Returns the Result</returns>
        [HttpPost, Route("register")]
        public async Task<IActionResult> RegisterUser([FromBody]RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await this.manager.CreateUserAsync(model);
                if (result.Succeeded)
                {
                    return Ok(new { Message = "Added Successfully" });
                }
            }
            return BadRequest("Registeration failed");
        }

        /// <summary>
        /// For login Existing User
        /// </summary>
        /// <param name="model">FromBody</param>
        /// <returns>Result</returns>
        [HttpPost, Route("login")]
        public async Task<IActionResult> LoginUser([FromBody]LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await this.manager.LoginUserAsync(model);
                if (result.Succeeded)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:_key"]));
                    var signInCr = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:_url"],
                        audience: configuration["Jwt:_url"],
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signInCr);
                    var FinalToken = new JwtSecurityTokenHandler().WriteToken(token);

                    /// this is to set for Cache
                    var key = this.distributedCache.GetString(model.Email);
                    this.distributedCache.SetString(key, FinalToken);
                    return Ok(new { Token = FinalToken });
                }
            }
            return BadRequest("Login Failed");
        }

        /// <summary>
        /// ForgotPassword
        /// </summary>
        /// <param name="model">FromBody</param>
        /// <returns>Result</returns>
        [HttpPost, Route("forgotpassword")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {

                var resettoken = await this.manager.GetResetToken(model);
                var link = Url.Action("resetpassword", "Account",
                    new { email = model.Email, token = resettoken }, Request.Scheme);
                return Ok(new { Reset_Password_Link = link });
            }
            return BadRequest();
        }

        /// <summary>
        /// Resets the Password for and Existing User
        /// </summary>
        /// <param name="model">FromBody</param>
        /// <returns>Result</returns>
        [HttpPost, Route("resetpassword")]
        public async Task<IActionResult> ResetPassword([FromBody]ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await this.manager.ResetPasswordAsync(model);
                if (result.Succeeded)
                {
                    return Ok(new { ResetStatus = "Success" });
                }
            }
            return BadRequest();
        }

        /// <summary>
        /// To Change the Password for an Existing User
        /// </summary>
        /// <param name="model">Data from the Body</param>
        /// <returns>Result</returns>
        [HttpPost, Route("changepassword")]
        public async Task<IActionResult> ChangePassword([FromBody]ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await this.manager.ChangePasswordAsync(model);
                if (result.Succeeded)
                {
                    return Ok(new { changePasswordStatus = "Success" });
                }
            }
            return BadRequest();
        }

        /// <summary>
        /// To Logout the User
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("logout")]
        public IActionResult Logout()
        {
            manager.LogoutAsync();
            return Ok("Logout Successfull");
        }
    }
}
