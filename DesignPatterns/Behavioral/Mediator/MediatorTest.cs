// <copyright file="MediatorTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Mediator
{
    using System;
    
    /// <summary>
    /// this class is just to test the Mediator Pattern
    /// </summary>
    public class MediatorTest
    {
        /// <summary>
        /// a simple static method to run the code without creating object of this class
        /// </summary>
        public static void DriverMethod()
        {
            //// creating the object of mediator
            IChatMediator mediator = new ChatMediatorImpl();
            
            //// ceating the user Objects
            User user1 = new UserImpl(mediator, "ashok");
            User user2 = new UserImpl(mediator, "Ramesh");
            User user3 = new UserImpl(mediator, "Shreshail");
            User user4 = new UserImpl(mediator, "Kamlesh");
            
            //// adding the user Objects to the mediator object where communication between the objects happens through
            //// the mediator
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);

            //// here 1 object sends a message which is recieved by all the objects through the mediator
            user1.Send("hello EveryOne");
            user2.Recieve("hi");
            mediator.SendMessage("hey", user1);

        }
    }
}
