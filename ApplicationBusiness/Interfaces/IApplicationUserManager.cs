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
        /// <param name="model">registerModel from body</param>
        /// <returns>Result
        /// </returns>
        Task<IdentityResult> CreateUserAsync(RegisterViewModel model);

        /// <summary>
        /// loggig in the User
        /// </summary>
        /// <param name="model">LoginModel from body</param>
        /// <returns>Result</returns>
        Task<SignInResult> LoginUserAsync(LoginViewModel model);

        /// <summary>
        /// this method logs the login user out
        /// </summary>
        /// <returns>Logouts the user</returns>
        void LogoutAsync();
        
        /// <summary>
        /// Generates the token against the user who forgot the password
        /// </summary>
        /// <param name="model">Email</param>
        /// <returns>Reset Password Token</returns>
        Task<string> GetResetToken(string email);

        /// <summary>
        /// Resets the Password based on the token
        /// </summary>
        /// <param name="model">Info of User</param>
        /// <returns>Result</returns>
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
        
        /// <summary>
        /// Changes the password when a user wants to change the Password
        /// </summary>
        /// <param name="model">ChangePasswordModel</param>
        /// <returns>Result</returns>
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);

        /// <summary>
        /// To Send the Reset Password Token to the MSMQ
        /// </summary>
        /// <param name="message">Token</param>
        void SendMassageToMSMQ(string message);

        /// <summary>
        /// To Retrieve the Message from MSMQ
        /// </summary>
        /// <returns>Token</returns>
        string RetrieveMessageFromMSMQ();

        /// <summary>
        /// To send the Reset link to the User
        /// </summary>
        /// <param name="link">the link</param>
        /// <param name="email">email of the user</param>
        /// <returns>Result</returns>
        dynamic SendMail(string link,string email);
    }
}
