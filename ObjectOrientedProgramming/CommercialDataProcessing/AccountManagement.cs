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