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
            ////running a  based on user
            switch (entered)
            {
                case 1: 
                    if (iv.Rice == null) 
                    {
                        iv.Rice = new List<Seeds>(); 
                    }

                    iv.Rice.Add(item);
                    break;
                case 2:
                    if (iv.Pulses == null) 
                    { 
                        iv.Pulses = new List<Seeds>(); 
                    }

                    iv.Pulses.Add(item);
                    break;
                case 3:
                    if (iv.Wheats == null) 
                    {
                        iv.Wheats = new List<Seeds>();
                    }

                    iv.Wheats.Add(item);
                    break;
                default:
                    Console.WriteLine("Invalid Entry try Again...");
                    break;
            }
            iv.Sum = sum;

            ////now serializing and writing to file directly 
            using (StreamWriter writer = File.CreateText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\InventoryManagement\JSON.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, iv);
                Console.WriteLine("new Product Added to the Inventory");
            }
        }
        /// <summary>
        /// this method deletes the brand specified by the user
        /// </summary>
        public void Delete()
        {