// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Account.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    /// <summary>
    /// this class manages the StockAccounts class
    /// </summary>
    public class AccountManagement
    {
       private static string  path = @"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\CommercialDataProcessing\Accounts.json";
 /// <summary>
        /// this method is used to run the Account Management program
        /// </summary>
        public static void DriverMethod()
        {
     ////creating own class to use its Methods
            AccountManagement ac = new AccountManagement();
            Console.WriteLine("Welcome to Stock Accounts" +
                "Enter 1 to dispaly account report\n" +
                "Enter 2 to remove an account\n" +
                "Enter 3 to Add a New account");
     switch (int.Parse(Console.ReadLine()))
            {
                case 1: Console.WriteLine("Enter Name: ");
                    ac.AcReport(Console.ReadLine());
                    break;
                case 2: Console.WriteLine("Enter Name: ");
                    ac.Remove(Console.ReadLine());
                    break;
                case 3: ac.Add();
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        /// <summary>
        /// to add new Accounts
        /// </summary>
        public void Add()
        {
            string jfile = File.ReadAllText(path);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }
Console.WriteLine("enter the Name: ");
            StockAccount ac = new StockAccount();
            ac.Fill(Console.ReadLine());