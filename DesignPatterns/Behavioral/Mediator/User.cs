// <copyright file="User.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Mediator
{
    using System;

    /// <summary>
    /// this abstract class resembles the user Objects and its function declared
    /// </summary>
    public abstract class User
    {
        protected IChatMediator mediator;
        protected string name;

        /// <summary>
        /// constructor to initialize the variables
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="name"></param>
        public User(IChatMediator mediator, String name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        /// <summary>
        /// a normal function to sending the message
        /// </summary>
        /// <param name="message"></param>
        public abstract void Send(string message);

        /// <summary>
        /// a normal function to recieving the message
        /// </summary>
        /// <param name="message"></param>
        public abstract void Recieve(string message);
    }
}
