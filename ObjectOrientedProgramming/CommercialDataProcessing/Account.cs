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
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// class as an account data type
    /// </summary>
    public class StockAccount
    {
        ////variable to hold the data about account 
        public double Cash { get; set; }

        public string Name { get; set; }
        
        public int N { get; set; }
        
        public List<int> Shares { get; set; }
        
        public List<string> Stocks { get; set; }
        
        public List<int> StockPrice { get; set; }
        
        public DateTime Timing = DateTime.Now;