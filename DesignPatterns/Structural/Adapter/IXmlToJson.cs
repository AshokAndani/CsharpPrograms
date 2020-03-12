// <copyright file="IXmlToJson.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Adapter
{
    using System;
    using System.Xml.Linq;

    /// <summary>
    ///  the interface which has the allow the class to convert the xml to json
    /// </summary>
    public interface IXmlToJson
    {
        /// <summary>
        ///  method declared which converts the xml to json
        /// </summary>
        /// <param name="xDocument"></param>
        /// <returns>json string</returns>
        string GetData(XDocument xDocument);

    }
}
