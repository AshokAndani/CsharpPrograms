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
/// <summary>
        /// <see cref="DeckOfCards"/> 
        /// do create a deck of cards 
        /// </summary>
        public DeckOfCards()
        {

//// this is the face of the card with numbres indicated
            string[] face = 
            {
                "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Jack", "Queen", "King"
            };

            ////the suits in string array
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            ////card array
            this.deck = new Card[this.numberOfCards];
            this.currentCard = 0;
            this.randomNumber = new Random();

            ////filling the card array
            for (int i = 0; i < this.numberOfCards; i++)
            {
                this.deck[i] = new Card(face[i % 13], suits[i % 3]);
            }
        }
/// <summary>
        /// to shuffle the cards in the deck by swapping
        /// </summary>
        public void Shuffle()
        {
this.currentCard = 0;
            for (int i = 0; i < this.deck.Length; i++)
            {
                int sec = this.randomNumber.Next(this.numberOfCards);

                Card temp = this.deck[i];
                this.deck[i] = this.deck[sec];
                this.deck[sec] = temp;
            }
        }