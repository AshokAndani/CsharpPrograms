// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedProgramming.PlayerQue
{
    using System;
    using System.Text;
    using ObjectOrientedProgramming.Cards;
    using DataStructures.Queue;
/// <summary>
    /// to fill the que of players
    /// </summary>
    public class PlayersToQue
    {
/// <summary>
        /// this mehod puts players into que and prints
        /// </summary>
        public static void DriverMethod()
        {
DeckOfCards deckOfCards = new DeckOfCards();

            deckOfCards.Shuffle();
//// the number of players given are 4 hence Queue size is 4
            Queue<Player> players = new Queue<Player>(4);