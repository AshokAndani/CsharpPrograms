// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Stock.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Stocks
{
    using System;
    using System.Collections.Generic;
    using System.Text;
 /// <summary>
    /// this class represents information of an Stock
    /// </summary>
    public class Stock
    {
     public String name { get; set; }
        public int NumberOfShares { get; set; }
        public int SharePrice { get; set; }
        public int StockPrice { get; set; }
/// <summary>
        /// string representation of Stock class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Name: {0}\nPrice: {1}\nNumber of Shares: {2}", name, SharePrice, NumberOfShares);
        }
    }
 /// <summary>
    /// this class contains the list of stocks and total stock price
    /// </summary>
    public class StockPortfolio
    {
        public int grandTotal { get; set; }
       public List<Stock> StockList;
    }
}
