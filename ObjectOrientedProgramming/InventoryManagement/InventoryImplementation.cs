/// --------------------------------------------------------------------------------------------------------------------
/// <copyright file=InventoryImplementation.cs" company="Bridgelabz">
///   Copyright © 2020 Company="BridgeLabz"
/// </copyright>
/// <creator name="ASHOKKUMAR"/>
//// --------------------------------------------------------------------------------------------------------------------
namespace InventoryManagement
{
    using System.Collections.Generic;
    using System;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this class manages the inventory json file
    /// </summary>
    public class InventoryImplementation
    {
        /// <summary>
        /// this () will add the items to inventory
        /// </summary>
        public void Add()
        {
            ////fetching the json file
            string jfile = File.ReadAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\InventoryManagement\JSON.json");

            ////creating the inventory object and assgning the deserialized value to it
            Inventory iv;
            iv = (Inventory)JsonConvert.DeserializeObject<Inventory>(jfile);
            if (iv == null)
            {
                iv = new Inventory();
            }

            int sum = 0;
            if (iv != null)
            {
                sum = iv.Sum;
            }
////creating a Seeds object to fill it in switch based on requirement
            Seeds item = new Seeds();

            ////asking the user to choose the given option
            Console.WriteLine("Enter 1--> for Rice\tEnter 2--> for Pulses\tEnter 3--> for Wheats\t");

            int entered = int.Parse(Console.ReadLine());

            ////filling the details
            Console.Write("Enter the name of the Product: ");
            item.brand = Console.ReadLine();
            Console.Write("Enter the Price per Kg: ");
            item.PricePerKg = int.Parse(Console.ReadLine());
            Console.Write("Enter the Weight: ");
            item.Weight = int.Parse(Console.ReadLine());
            item.TotalPrice = item.PricePerKg * item.Weight;
            if (iv != null)
            {
                sum += item.TotalPrice;
            }
            else
            {
                sum = item.TotalPrice;
            }