// <copyright file="AuthContoller.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace JwtAuthorization.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using JwtAuthorization.ViewModel;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    /// <summary>
    /// this controller class provides the actions to register and login the user
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;

        /// <summary>
        /// to inject the UserManager and Configuration objects
        /// </summary>
        /// <param name="userManager">provides the UserManager object</param>
        /// <param name="configuration">provides the Configuration object</param>
        public AuthController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        /// <summary>
        /// this method is used to insert the user
        /// </summary>
        /// <param name="model">Supplied by the Web Page</param>
        /// <returns>return the json format username</returns>
        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> InsertUser(RegisterViewModel model)
        {
            //// assigning the model information to the IdentityUser
            var user = new IdentityUser
            {
                Email = model.Email,
                UserName = model.Email,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            //// saving the User to the DB
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {

                //// to assign the user a specific role
                await userManager.AddToRoleAsync(user, "CUSTOMER");
            }

            //// to return Ok after saving the user
            return Ok(new { Username = user.UserName });
        }

        /// <summary>
        /// this method is used to login the user
        /// </summary>
        /// <param name="model">supplied by the Web Application</param>
        /// <returns>returns jwt token for valid user</returns>
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            //// finding the user
            var user = await userManager.FindByNameAsync(model.UserName);
            
            //// if the user is valid the enter the if condition
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                //// generating the claims
                var claim = new[]
                {
                    //// assign the claim to user
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName)
                };
                //// generating the signinKey
                var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SigninKey"]));
                
                //// setting the expiration time
                int expiryInMinutes = Convert.ToInt32(configuration["Jwt:ExpiryInMinutes"]);

                //// Creating the token
                var token = new JwtSecurityToken(
                    issuer: configuration["Jwt:Site"],
                    audience: configuration["Jwt:Site"],
                    expires: DateTime.Now.AddMinutes(expiryInMinutes),
                    signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                    );
                //// if Success return Ok
                return Ok(
                    new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    }
                    );
            }
            //// if failed return Unauthorised
            return Unauthorized();
        }
    }
}
