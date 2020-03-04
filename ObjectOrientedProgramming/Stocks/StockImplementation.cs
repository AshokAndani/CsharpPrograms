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