/// --------------------------------------------------------------------------------------------------------------------
/// <copyright file=AddressBookImplementation.cs" company="Bridgelabz">
///   Copyright © 2020 Company="BridgeLabz"
/// </copyright>
/// <creator name="ASHOKKUMAR"/>
//// --------------------------------------------------------------------------------------------------------------------

namespace InventoryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
/// <summary>
    /// this is the class for seeds for every type
    /// </summary>
    public class Inventory
    {
        public int Sum { get; set; }
        public List<Seeds> Rice;
        public List<Seeds> Pulses;
        public List<Seeds> Wheats;
    }
    public class Seeds
    {
        public string brand;
        public int PricePerKg;
        public int Weight;
        public int TotalPrice;
