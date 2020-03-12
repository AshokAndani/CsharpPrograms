// <copyright file="Fruit.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Visitor
{
    using System;

    /// <summary>
    ///  this is the Fruit class whose code cannot be changed
    /// </summary>
    public class Fruit : IItemElement
    {
        private int pricePerKg;
        private int weight;
        private string name;

        /// <summary>
        /// constructor for initialization
        /// </summary>
        /// <param name="price"></param>
        /// <param name="weight"></param>
        /// <param name="name"></param>
        public Fruit(int price, int weight,string name)
        {
            this.pricePerKg = price;
            this.weight = weight;
            this.name = name;
        }

        /// <summary>
        /// this property is to make the fields available in the vistorimplimentation
        /// </summary>
        public int GetPricePerKg
        {
            get
            {
                return this.pricePerKg;
            }
        }
        public int GetWeight
        {
            get
            {
                return this.weight;
            }
        }
        public string GetName
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        ///  implemented method from the Parent interface
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
