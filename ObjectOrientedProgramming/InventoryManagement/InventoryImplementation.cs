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
        private static string filepath = @"C:\Users\yempc73\Desktop\FellowShip\ObjectOrientedProgramming\ObjectOrientedProgramming\InventoryManagement\JSON.json";
        /// <summary>
        /// this () will add the items to inventory
        /// </summary>
        public void Add()
        {
            ////fetching the json file
            string jfile = File.ReadAllText(filepath);

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

            //// adding the new inventory price to the Iv(Inventroy Object)
            iv.Sum = sum;

            ////now serializing and writing to file directly 
            using (StreamWriter writer = File.CreateText(filepath))
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
            Console.WriteLine("Are you sure you Want to delete...items from Inventory: ");

            //// fetching the jsonstring from the file
            string jfile = File.ReadAllText(filepath);

            ////to deserialize the Object to use the Object
            Inventory iv = JsonConvert.DeserializeObject<Inventory>(jfile);

            Console.WriteLine("Enter 1--> for Rice\tEnter 2--> for Pulses\tEnter 3--> for Wheats\t");

            int entered = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the brand");
            
            string brand = Console.ReadLine();
            
            int sum = iv.Sum;
            
            switch (entered)
            {
                case 1:
                    foreach (Seeds s in iv.Rice)
                    {
                        if (s.brand.Equals(brand))
                        {
                            sum -= s.TotalPrice;
                            iv.Rice.Remove(s);
                            break;
                        }
                    }

                    break;
         
                case 2:
                    foreach (Seeds s in iv.Pulses)
                    {
                        if (s.brand.Equals(brand))
                        {
                            sum -= s.TotalPrice;
                            iv.Pulses.Remove(s);
                            break;
                        }
                    }

                    break;
                
                case 3:
                    foreach (Seeds s in iv.Wheats)
                    {
                        if (s.brand.Equals(brand))
                        {
                            sum -= s.TotalPrice;
                            iv.Wheats.Remove(s);
                            break;
                        }
                    }

                    break;
                default:
                    Console.WriteLine("there is no such brand available in Inventory");
                    break;
            }

            //// replacing the total sum of the iv with substracted sum
            iv.Sum = sum;
            
            ////now filling the file with updated inventory
            using (StreamWriter stream = File.CreateText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, iv);
            }
        }

        /// <summary>
        /// to display the total price in inventory
        /// </summary>
        public void DisplayOutput()
        {
            ////converting the json file to String
            string jfile = File.ReadAllText(filepath);
            
            ////to ensure the json has contents to deserialize
            if(jfile.Length<1)
            {
                Console.WriteLine("Inventory is Empty Please add the contents");
                return;
            }

            ////now desializing the json string
            Inventory iv = JsonConvert.DeserializeObject<Inventory>(jfile);

            Console.WriteLine("Enter 1 to show the total Enventory Cost\n Enter 2 to Display json string");
            int entered = int.Parse(Console.ReadLine());

            switch (entered)
            {
                case 1: Console.WriteLine("the total inventory cost is : " + iv.Sum);
                    break;
                case 2: Console.WriteLine(jfile) ;
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }

        }
    }
}