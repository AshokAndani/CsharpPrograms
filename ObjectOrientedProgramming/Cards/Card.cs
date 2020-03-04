// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Card.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedProgramming.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text;
        /// <summary>
    /// CLASS CARD FOR POKER SIMULATION
    /// </summary>
    public class Card
    {
                private string suit, value;
/// <summary>
        /// card Constructor
        /// </summary>
        /// <param name="tvalue">value to input</param>
        /// <param name="tsuit">suit to input</param>
        public Card(string tvalue, string tsuit)
        {
            this.suit = tsuit;
            this.value = tvalue;
        }