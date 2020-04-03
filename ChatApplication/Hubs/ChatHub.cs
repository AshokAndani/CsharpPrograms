// <copyright file="ChatHub.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace ChatApplication.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ChatApplication.Models;
    using Microsoft.AspNetCore.SignalR;

    /// <summary>
    /// this class extends the Hub class from signalR
    /// </summary>
    public class ChatHub : Hub
    {
        private readonly DataDbContext context;

        /// <summary>
        /// injecting the DatabaseContext through the constructor
        /// </summary>
        /// <param name="context"></param>
        public ChatHub(DataDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// this is a SendMessage method which is invoked by the client side code when someone send the message
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            
               await context.users.AddAsync(new User {UserName=user, Message=message});
            await context.SaveChangesAsync();
        }
    }
}
