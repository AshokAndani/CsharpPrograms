// <copyright file="ChatHub.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace GroupChat.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GroupChat.Repository;
    using Microsoft.AspNetCore.SignalR;
    
    /// <summary>
    /// this class extends the Hub class from the signalR
    /// </summary>
    public class ChatHub : Hub
    {
        public IMessageHandler handler;

        /// <summary>
        /// this method sends the message to all the members of the active group
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendMessageToGroup(string groupName, string message)
        {
            //// this code is for database operations
            var user = new UserAndMessage()
            {
                GroupName = groupName,
                Message = message,
                SocketID = Context.ConnectionId
            };

            //handler.AddMessages(user);

            ////this code is main which invokes the Client side method
            return Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId}: {message}");
        }

        /// <summary>
        /// this class adds the new User to the group
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        /// <summary>
        /// this method remove the user from the Group
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public async Task RemoveFromGroup(string groupName)
        {
            //handler.DeleteMessages(Context.ConnectionId);
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");
        }

        /// <summary>
        /// for private messages
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendPrivateMessage(string user, string message)
        {
            return Clients.User(user).SendAsync("ReceiveMessage", message);
        }
    }
}