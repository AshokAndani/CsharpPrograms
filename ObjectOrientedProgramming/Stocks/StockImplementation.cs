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

/// <summary>
        /// to display the stock valuees as output 
        /// </summary>
        public void ValueOfStacks()
        {
 ////fetching json
            string jfile = File.ReadAllText(path);

            ////initializing
            StockPortfolio st;

            ////validating json string
            if (jfile.Length < 1)
            {
                Console.WriteLine("there are no stocks");
                return;
            }
            else
            {
                st = JsonConvert.DeserializeObject<StockPortfolio>(jfile);
            }
Console.WriteLine("Enter 1 to Display Total Share value\t Enter 2 to display total sharePrice of particular stock");
            int entered = int.Parse(Console.ReadLine());
switch (entered)
            {
                case 1: Console.WriteLine("total price of all stocks are: "+ st.grandTotal);
                    break;
                case 2:
                    Console.Write("Enter the name: ");
                    string name = Console.ReadLine();
                    foreach(Stock s in st.StockList)
                    {
                        if(s.name.Equals(name))
                        {
                            Console.WriteLine("the Total Stock value of "+name+" is : "+s.StockPrice);
                        }
                    }
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }
           


        }
    }
}