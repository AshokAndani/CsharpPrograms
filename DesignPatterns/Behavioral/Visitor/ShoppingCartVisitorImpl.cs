// <copyright file="ShoppingCartVisitorImpl.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Visitor
{
    using System;

    /// <summary>
    /// this is the implementation class of visitor interface which has the logic to do while iterating through the
    /// objects of concrete class
    /// </summary>
    public class ShoppingCartVisitorImpl : IShoppingCartVisitor
    {

        /// <summary>
        /// visit method which has to be implented and written the required logic only in this class
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int visit(Book book)
        {
            int cost = 0;
            //// any kind of logics can be performed here 
            //// now applying the Tax for Example
            if (book.GetPrice > 50)
            {
                cost = book.GetPrice + 5;
                Console.WriteLine("ISBN: {0} book Price with Tax :{1}",book.GetIsbnNumber,cost);
            }
            else
            {
                cost = book.GetPrice;
                Console.WriteLine("ISBN number: {0} and price without Tax: {1}", book.GetIsbnNumber, cost);
            }
                return cost;
        }

        public int visit(Fruit fruit)
        {
            int cost = 0;
            //// Here Different logic for Fruits
            if (fruit.GetPricePerKg > 300)
            {
                cost = fruit.GetPricePerKg;
                Console.WriteLine("{0} is Eligible for Free Delivery as the PricePerKg is Rs.{1}.00/-", fruit.GetName, fruit.GetPricePerKg);
            }
            else
            {
                Console.WriteLine("{0} total cost with Delivary Charge is {1}+50/-(delivery charge)", fruit.GetName, fruit.GetPricePerKg);
                cost = fruit.GetPricePerKg + 50;
            }
            return cost;
        }
    }
}
