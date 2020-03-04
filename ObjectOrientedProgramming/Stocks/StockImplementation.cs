// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StockImplementation.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Stocks
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
/// <summary>
    /// this class contains the operation respective to Stock Object
    /// </summary>
    public class StockImplementation
    {
public static string path = @"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\Stocks\Stocks.json";
/// <summary>
        /// this method adds the new stock entry
        /// </summary>
        public void AddStock()
        {
////Fetching the json file
            string jfile = File.ReadAllText(path);

            ////initializing the Object
            StockPortfolio st;

            ////validating the json file not to be empty
            if (jfile.Length < 1)
            {
                st = new StockPortfolio();
                st.StockList = new List<Stock>();
                st.grandTotal = 0;
            }
            else
            {
                st = JsonConvert.DeserializeObject<StockPortfolio>(jfile);
            }
////creating a stock
            Stock s = new Stock();
////taking the user input to fill the stock 
            Console.Write("Enter the new Stock Name:");
            s.name = Console.ReadLine();
            Console.Write("Enter the share Price For stock: ");
            s.SharePrice = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number Of Shares: ");
            s.NumberOfShares = int.Parse(Console.ReadLine());
            s.StockPrice = s.SharePrice * s.NumberOfShares;
            st.grandTotal += s.StockPrice;
            st.StockList.Add(s);
////writing into the file directly
            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, st);
            }

                Console.WriteLine("Added Successfully");
        }