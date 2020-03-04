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
//// iterating through 4 players
            for(int i = 1; i <= 4; i++)
            {
                Player p = new Player();

                ////Number of cards per player are 9 hence Queue size is 9
                p.cards = new Queue<Card>(9);
                
                //// iterating throgh 9 cards
                for (int j = 1;j<=9;j++)
                {
                  p.cards.Enqueue(deckOfCards.TakeCard());
                }
                
                players.Enqueue(p);
            }
//// for printing the players with the cards are
            ////hence again iterating through all players print the cards players having
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("player----------------- " + i);
                Player p = players.Dequeue();
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(p.cards.Dequeue() + " \n");
                }
            }
        }
    }
public class Player
    {
        public Queue<Card> cards;

        public override string ToString()
        {
            return cards.ToString();
        }
    }
}