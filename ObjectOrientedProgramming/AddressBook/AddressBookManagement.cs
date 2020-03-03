/// --------------------------------------------------------------------------------------------------------------------
/// <copyright file=AddressBookManagement.cs" company="Bridgelabz">
///   Copyright © 2020 Company="BridgeLabz"
/// </copyright>
/// <creator name="ASHOKKUMAR"/>
//// --------------------------------------------------------------------------------------------------------------------

namespace AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

 /// <summary>
    /// this class controls the AddressBookImplementation
    /// </summary>
    class AddressBookManagement
    { 
 /// <summary>
 /// this () is responsible to manage all the operation related to AddressBook
/// </summary>
        public static void DriverMethod()
        {
            ////creating the AddressBookImplementation object
            AddressBookImplementation ad = new AddressBookImplementation();

            while (true)
            {
                ////this is to provide information to user about name of the OPerations
                Console.WriteLine("Enter the String given below to Perform respective Operations" +
                    "\nDisplay--to display all the Persons info from List\n" +
                    "Add--to add a new Person\n" +
                    "delete--to delete a Person\n" +
                    "Edit-- to edit Existing person's info");
                string entered = Console.ReadLine();

                ////using switch case to jump to required operation
                switch (entered)
                {
                    case "Add": ad.AddPerson();
                        break;
                    case "Delete": ad.Delete();
                        break;
                    case "Edit": ad.Edit();
                        break;
                    case "Display": ad.DisplayJson();
                        break;
                    default: Console.WriteLine("Invalid Entry");
                        break;
                }    
}
