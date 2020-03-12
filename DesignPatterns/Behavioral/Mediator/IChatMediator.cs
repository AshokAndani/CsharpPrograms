// <copyright file="IChatMediator.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Mediator
{
    using System;

    /// <summary>
    /// this is the interface which holds the declared methods which cleint needs
    /// </summary>
    public interface IChatMediator
    {
        public void SendMessage(String msg, User user);
        public void AddUser(User user);
    }
}
