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