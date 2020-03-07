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

    public class StockManagement
    {
        public static void DriverMethod()
        {
            Console.WriteLine("Welcome to Stock Management \n" +
                "Enter 1 to Add new Stock\n" +
                "Enter 2 for the Total Value of Stock");
            int entered = int.Parse(Console.ReadLine());
            
            ////created the StockImplementation class
            StockImplementation im = new StockImplementation();

            switch(entered)
            {
                case 1: im.AddStock();
                    break;
                case 2: im.ValueOfStacks();
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}