// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DeckOfCards.cs" company="Bridgelabz">
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
    /// this is to create a deck full of cards
    /// </summary>
    public class DeckOfCards
    {
 private Card[] deck;
        private int currentCard;
        readonly private int numberOfCards = 52;
        private Random randomNumber;