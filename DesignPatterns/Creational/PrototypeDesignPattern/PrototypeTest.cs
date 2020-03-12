// <copyright file="PrototypeTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Creational.PrototypeDesignPattern
{
    using System;
    /// <summary>
    ///  this class is used to manage the Prototype pattern classes
    /// </summary>
    class PrototypeTest
    {
        /// <summary>
        /// this is a simple static method used to run without creating its class Object
        /// </summary>
        public static void DriverMethod()
        {
            //// simulates the PersonShallowCopy class
            PersonShallowCopy originalShallow = new PersonShallowCopy();
            originalShallow.name = "Ashok";
            originalShallow.age = 23;
            originalShallow.address = new Address("Banglore", "Karnataka", "India");

            //// now printing the original copy
            Console.WriteLine("Original copy of Shallow------------------------>");
            Console.WriteLine(originalShallow);

            ////now creating the prototype of the original copy
            PersonShallowCopy duplicateShallow = (PersonShallowCopy)originalShallow.Clone();

            //// making changes to the cloned copy
            duplicateShallow.name = "Pavan";
            duplicateShallow.age = 24;
            duplicateShallow.address.city = "Pune";
            duplicateShallow.address.state = "Maharashtra";
            duplicateShallow.address.Country = "India";

            ////printing the duplicate copy
            Console.WriteLine("Duplicate copy of Shallow------------------>-\n" + duplicateShallow);

            //// again priniting the original copy of the shallow copy
            Console.WriteLine("once again Original copy of the Shallow ---------------------------->\n" + originalShallow +
                "_________________________________Deep clone____________________________________________________________");

            //// now deep copy simulation
            PersonDeepCopy deepCopyOriginal = new PersonDeepCopy();

            deepCopyOriginal.name = "Ashok";
            deepCopyOriginal.age = 23;
            deepCopyOriginal.address = new Address("Banglore", "Karantaka", "India");

            //// Creating the clone
            PersonDeepCopy DeepDuplicate = (PersonDeepCopy)deepCopyOriginal.Clone();

            DeepDuplicate.name = "Pavan";
            DeepDuplicate.age = 24;
            DeepDuplicate.address.city = "Pune";
            DeepDuplicate.address.state = "Maharashtra";
            DeepDuplicate.address.Country = "India";

            //// printing the original copy of deepCopy
            Console.WriteLine("Original copy--------------------------------------->\n" + deepCopyOriginal);

            //// Printing the cloned copy
            Console.WriteLine("Duplicate----------------------------------->\n" + DeepDuplicate);

            //// again printing the Original copy
            Console.WriteLine("Again printing the origin copy------------------->\n" + deepCopyOriginal);
        }
    }
}
