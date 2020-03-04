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