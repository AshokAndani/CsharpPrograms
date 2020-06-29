// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BookStore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using BookStore.ApplicationBusiness.Interface;
    using BookStore.Models;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// this controller is used to hanflr the Accounts
    /// </summary>
    public class AccountController : Controller
    {
        private readonly IApplicationUserManager manager;
        private readonly ILogger<AccountController> logger;

        public AccountController(IApplicationUserManager manager, ILogger<AccountController> logger)
        {
            this.manager = manager;
            this.logger = logger;
        }

        /// <summary>
        /// to register the new user
        /// </summary>
        /// <param name="model">Register Model</param>
        /// <returns></returns>
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
        /// to login the User
        /// </summary>
        /// <param name="model">Login View Model</param>
        /// <returns></returns>
        [HttpPost, Route("login")]
        public async Task<IActionResult> LoginUser([FromBody]LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await this.manager.LoginUserAsync(model);
               if (result.Succeeded)
                {
                    //// GetJwtToken is an Explicit method that creates the jwt token
                    var FinalToken = this.manager.GetJwtToken(model.Email);
                    return Ok(new { Token = FinalToken });
                }
            }
            logger.LogInformation(model.Email+" tried to login which Failed");
            return BadRequest("Login Failed");
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
        /// <returns>To Logout</returns>
        [HttpGet, Route("logout")]
        public  IActionResult Logout()
        {
             manager.LogoutAsync();
            return Ok("Logout Successfull");
        }
    }
}
