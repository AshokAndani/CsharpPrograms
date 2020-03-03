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