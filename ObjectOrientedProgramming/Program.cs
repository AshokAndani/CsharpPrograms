// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOps
{
    using System;
    using System.IO;
    using AddressBook;
    using CommercialDataProcessing;
    using InventoryManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ObjectOrientedProgramming.Cards;
    using Stocks;
    
    
    /// <summary>
    /// this program the Entry Point program for OOPS Project
    /// </summary>
   public class Program
    {
        /// <summary>
        /// main () which is the 1st () to be invoked by the CLR
        /// </summary>
        /// <param name="args">this in never used</param>
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for AddressBook\n" +
                "Enter 2 for InventoryManagement\n" +
                "Enter 3 For Stock Management\n" +
                "Enter 4 for Account Management\n" +
                "Enter 5 for CardSimulation");
            int number = int.Parse(Console.ReadLine());
           
            ////using switch case to select the required class
            switch (number)
            {
                case 0:
                    new Test();
                    break;
                case 1: AddressBookManagement.DriverMethod();
                    break;
                case 2: InventoryManagement.DiverMethod();
                    break;
                case 3: StockManagement.DriverMethod();
                    break;
                case 4: AccountManagement.DriverMethod();
                    break;
                case 5: CardsSimulation.DriverMethod();
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
