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