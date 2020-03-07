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
    using Newtonsoft.Json;

    /// <summary>
    /// this class contains the operation respective to Stock Object
    /// </summary>
    public class StockImplementation
    {
        public static string path = @"C:\Users\yempc73\Desktop\FellowShip\ObjectOrientedProgramming\ObjectOrientedProgramming\Stocks\Stocks.json";
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
                //// if the file is Empty -> explicitly creating the Objects of List and StockPortfolio to add add the details in them
                st = new StockPortfolio();
                st.StockList = new List<Stock>();
                st.grandTotal = 0;
            }
            else
            {
                ////if the data is present in the json it implicitly creates the required Objects
                st = JsonConvert.DeserializeObject<StockPortfolio>(jfile);
            }

            ////creating a stock which will be added to the List of Stocks of StockPortfolio
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

            //// here as stock Object has all the data so, adding this Object to Stocklist
            st.StockList.Add(s);

            ////writing into the file directly(in this way serialization and Writing into file both happens)
            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, st);
            }

            Console.WriteLine("Added Successfully");
        }

        /// <summary>
        /// to display the stock values as output 
        /// </summary>
        public void ValueOfStacks()
        {
            ////fetching json
            string jfile = File.ReadAllText(path);

            ////initializing
            StockPortfolio st;

            ////validating json string should not to be empty
            if (jfile.Length < 1)
            {
                //// If string is empty there is no data to delete hence returns empty without doing anything
                Console.WriteLine("there are no stocks");
                return;
            }
            else
            {
                //// if data exists then will have to deserialize the string to Obeject to perform the Deletion Operation
                st = JsonConvert.DeserializeObject<StockPortfolio>(jfile);
            }

            Console.WriteLine("Enter 1 to Display Total Share value\t Enter 2 to display total sharePrice of particular stock");
            int entered = int.Parse(Console.ReadLine());

            switch (entered)
            {
                case 1:
                    Console.WriteLine("total price of all stocks are: " + st.grandTotal);
                    break;
                case 2:

                    //// name suggestions for the user
                    Console.WriteLine("Name suggestions:");
                    foreach (Stock s in st.StockList)
                    {
                        Console.Write("\"" + s.name + "\" ");
                    }
                    Console.Write("\nEnter the name: ");
                    string name = Console.ReadLine();
                    foreach (Stock s in st.StockList)
                    {
                        if (s.name.Equals(name))
                        {
                            Console.WriteLine("the Total Stock value of " + name + " is : " + s.StockPrice);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }



        }
    }
}