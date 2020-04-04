// <copyright file="IMessageHandler.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GroupChat.Repository
{
    public  class MessageHandler : IMessageHandler
    {
        private readonly DatabaseContext context;

        public MessageHandler(DatabaseContext context)
        {
            this.context = context;
        }
        public void AddMessages(UserAndMessage user)
        {
            context.MessagesTb.Add(user);
            context.SaveChanges();
        }
        public void DeleteMessages(string userID)
        {
            context.SaveChanges();
        }

    }
}
