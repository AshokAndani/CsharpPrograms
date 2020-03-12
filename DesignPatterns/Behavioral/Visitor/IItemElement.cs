// <copyright file="ItemElement.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Behavioral.Visitor
{
    using System;
   
    /// <summary>
    ///  this is the interface that every concrete classes should implement
    /// </summary>
    public interface IItemElement
    {
        public int Accept(IShoppingCartVisitor visitor);
    }
}
