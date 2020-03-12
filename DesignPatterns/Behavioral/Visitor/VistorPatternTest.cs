// <copyright file="VisitorPatternTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>


namespace DesignPatterns.Behavioral.Visitor
{
    using System;

    /// <summary>
    /// this is the class to test the visitor Pattern
    /// </summary>
    public class VistorPatternTest
    {

        /// <summary>
        /// simple static method to run the code without creating this class object
        /// </summary>
    public static void DriverMethod()
        {
            IItemElement[] items = { new Book(45, "2343"), new Fruit(500, 6, "Banana"), new Fruit(200, 3, "Pinapple"), 
                new Book(60, "5455") };
            int amount=CalculateTotalPrice(items);
            Console.WriteLine(amount);

        }

        /// <summary>
        /// example method to calculate the totalprice of the items that are in the list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private static int CalculateTotalPrice(IItemElement[] items)
        {
            int sum = 0;
            IShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            foreach (IItemElement item in items)
            {
                sum = sum + item.Accept(visitor);
            }
            return sum;
        }
    }
}
