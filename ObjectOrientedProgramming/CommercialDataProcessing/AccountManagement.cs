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
ls.Add(ac);

            string serial = JsonConvert.SerializeObject(ls);
            File.WriteAllText(path, serial);
            Console.WriteLine("done");
////directly writing into file
            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }

            Console.WriteLine("Successfully added");
        }
/// <summary>
        /// to remove existing accounts
        /// </summary>
        /// <param name="name">user enters the name</param>
        public void Remove(string name)
        {
    //// fetching string from json
            string jfile = File.ReadAllText(path);

            //// initializing the Object
            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }