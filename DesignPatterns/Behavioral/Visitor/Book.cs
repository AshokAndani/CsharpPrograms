// <copyright file="Book.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Visitor
{
    using System;

    /// <summary>
    ///  this is the book class whose code cannot be changed 
    /// </summary>
    public class Book : IItemElement
    {
        private int price;
        private string isbnNumber;

        /// <summary>
        /// initializing the variables throw the constructor
        /// </summary>
        /// <param name="price"></param>
        /// <param name="isbn"></param>
        public Book(int price, string isbn)
        {
            this.price = price;
            this.isbnNumber = isbn;
        }
        public int GetPrice
        {
            get
            {
                return this.price;
            }
        }
        public string GetIsbnNumber
        {
            get
            {
                return this.isbnNumber;
            }
        }

        /// <summary>
        /// this is the implemented method which has potential to iterate through the code without changing 
        /// the source code
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns> return type according to the requirement</returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
