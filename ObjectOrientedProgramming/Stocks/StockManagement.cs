// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StockManagement.cs" company="Bridgelabz">
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
///summary
/// this method simulates the stock
///summary
 public class StockManagement
    {
     public static void DriverMethod()
        {
            Console.WriteLine("Welcome to Stack Management \n" +
                "Enter 1 to Add new Stock");
            int entered = int.Parse(Console.ReadLine());
            
            ////created the StockImplementation class
            StockImplementation im = new StockImplementation();