// <copyright file="UserImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// this class implements the User abstract class and have definition for some abstract methods
    /// </summary>
    public class UserImpl : User
    {
        /// <summary>
        /// constructor to initialize the parent class constructor
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="name"></param>
        public UserImpl(IChatMediator mediator, string name) : base(mediator,name)
        {
        }

        /// <summary>
        /// this method prints the message recieved by this object
        /// </summary>
        /// <param name="message">sms</param>
        public override void Recieve(string message)
        {
            System.Console.WriteLine(this.name+" Recieved Message ="+message);
            
        }

        /// <summary>
        /// this method sends the message to other objects via mediator
        /// </summary>
        /// <param name="message">sms</param>
        public override void Send(string message)
        {
            System.Console.WriteLine(this.name+" Sending Message ="+message);
            this.mediator.SendMessage(message, this);
        }
    }
}