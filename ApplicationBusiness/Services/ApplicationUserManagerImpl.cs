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
    using CloudinaryDotNet;
    using Common.Models;
    using Experimental.System.Messaging;
    using MailKit.Net.Smtp;
    using Microsoft.AspNetCore.Identity;
    using MimeKit;
    using MimeKit.Text;

    /// <summary>
    /// this class is the implementation of the IApplicationUserManager
    /// </summary>
    public class ApplicationUserManagerImpl : IApplicationUserManager
    {
        /// <summary>
        /// UserManager which manages the User Account
        /// </summary>
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;

        /// <summary>
        /// SignInManager which Manages the Login And Logout of the users
        /// </summary>
        private readonly SignInManager<IdentityUser> signInManager;

        /// <summary>
        /// Constructor for injecting the UserManager and SignInManager
        /// </summary>
        /// <param name="userManager">Injects UserManager</param>
        /// <param name="signInManager">Injects SignInManager</param>
        public ApplicationUserManagerImpl(IConfiguration configuration, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration=conconfiguration;
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
        public async Task<string> GetResetToken(string email)
        {
            //// finding the wether the user exists with Email
            var user = await this.userManager.FindByEmailAsync(email);

            //// Checking if the Email is Comfirmed 
            if (user != null)
            {
                //// generating the token
                var token = await this.userManager.GeneratePasswordResetTokenAsync(user);
                var NewToken = new { token = token };
                return NewToken.token;
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
        /// Logut the user
        /// </summary>
        /// <returns>Logout</returns>
        public async void LogoutAsync()
        {
            await this.signInManager.SignOutAsync();
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

        /// <summary>
        /// To Retrive the Message from the Que
        /// </summary>
        /// <returns>Message</returns>
        public string RetrieveMessageFromMSMQ()
        {
            //// Creating the MessageQueue which fetch the sms from the MS MQ
            var messageQueue = new MessageQueue(@".\Private$\MyQueue");
            //// To recieve the Message from the Queue
            var message = messageQueue.Receive();
            //// Formatting the incoming message Compulsary
            message.Formatter = new XmlMessageFormatter(new string[] { "System.String, mscorlib" });
            //// Converting the Message To ToString
            var msg = message.Body.ToString();
            //// Returning the message
            return msg;
        }

        /// <summary>
        /// To Send the Message to the MSMQ
        /// </summary>
        /// <param name="message">Sending Message</param>
        public void SendMassageToMSMQ(string message)
        {
            //// initializing the MessageQueue
            MessageQueue messageQueue;
            //// Checking if the MessageQueue with Specified Path Exists
            if (MessageQueue.Exists(@".\Private$\MyQueue"))
            {
                //// Creating the object in the same path
                messageQueue = new MessageQueue(@".\Private$\MyQueue");
            }
            else
            {
                //// Creating the Object with the new Path
                messageQueue = MessageQueue.Create(@".\Private$\MyQueue");
            }

            //// Creating the Message object(MessageQueue fetches the Message object from the Queue)
            Message msg = new Message();
            messageQueue.Label = "Token";
            //// Sending the Message to the Queue
            messageQueue.Send(message);
        }

        /// <summary>
        /// To Send the Mail to the Email
        /// </summary>
        /// <param name="link">Link</param>
        /// <param name="email">Email of the User</param>
        /// <returns></returns>
        public dynamic SendMail(string link, string email)
        {
            //// preparing the MimeMessage Object
            var messageToSend = new MimeMessage
            {
                //// Details of the Sender
                Sender = new MailboxAddress("Ashok", configuration["Account:Email"]),
                //// Subject of the content
                Subject = "Link to Reset your Password"
            };
            //// from whom the message to Send
            messageToSend.From.Add(new MailboxAddress("Ashok", configuration["Account:Email"]));
            //// Body of the Message
            messageToSend.Body = new TextPart(TextFormat.Html) { Text = link };
            //// to Whom the Message to Send
            messageToSend.To.Add(new MailboxAddress("ashok34589@gmail.com"));

            //// Creating the smtp Clint object which is responsible to Connect to the smtp Server and send the Message
            var client = new SmtpClient();
            //// Smtp Client Details
            client.Connect("smtp.gmail.com", 587);
            //// For our Testing project removing the Authentication
            client.AuthenticationMechanisms.Remove("XOAUTH2");
            //// Sender Credentials(Dont forget to hide the Details)
            client.Authenticate(configuration["Account:Email"], configuration["Account:Password"]);
            //// this method will send the Message only if Authentiaction is Successfull
            client.Send(messageToSend);
            //// After Sending the Message Disconnecting the Connection with the Server
            client.Disconnect(true);
            //// Returning True
            return true;
        }
    }
}
