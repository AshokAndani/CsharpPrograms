// <copyright file="ShoppingCartVisitor.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Visitor
{
    using System;
    
    /// <summary>
    ///  this class is the main interface for visitor pattern
    /// </summary>
    public interface IShoppingCartVisitor
    {
        /// <summary>
        /// same signature visit methods for all the implimenting concrete classes
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        int visit(Book book);
        int visit(Fruit fruit);
    }
}
