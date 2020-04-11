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
    using System.Linq;
    using System.Threading.Tasks;
    using ApplicationBusiness.Interfaces;
    using Common.Models;
    using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// Injecting the IAppliactionUserManager in Constructor
        /// </summary>
        /// <param name="manager">Provides the implemented object</param>
        public AccountController(IApplicationUserManager manager)
        {
            this.manager = manager;
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
                    return Ok(new { LoggedUser = model.Email });
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

    }
}
