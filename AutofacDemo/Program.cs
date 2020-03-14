// <copyright file="Program.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace AutofacDemo
{
    using System;
    using AutofacDemo.DEWithAutofac;
    using Autofac;

    /// <summary>
    /// this class drives the classes related to DE
    /// </summary>
    public class Program
    {
        /// <summary>
        /// static method to run the code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //// this is without using the container where the code remains hard-coupled with this class 
            Console.WriteLine("-----created the instance in the higher module without autofac-----");
            INotificationService service = new NotificationServiceImpl();
            IUser user1 = new UserImpl(service);
            user1.ChangeUserName("Ashok");

            //// this is with using the autofac container which is totally loose-coupled with this class
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("<-----let the autofac contaner to create the instance------>");
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<NotificationServiceImpl>().As<INotificationService>();
            builder.RegisterType<UserImpl>().As<IUser>();
            IContainer container = builder.Build();
            var user = container.Resolve<IUser>();
            user.ChangeUserName("ashok");
        }
    }
}
