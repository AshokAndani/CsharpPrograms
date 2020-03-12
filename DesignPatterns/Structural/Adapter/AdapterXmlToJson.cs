// <copyright file="AdapterXmlToJson.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Adapter
{
    using System;
    using System.Xml.Linq;
    using System.Linq;
    using Newtonsoft.Json;
    /// <summary>
    ///  this class the called as adapter because this bridges the gap between the code which cannot be changed but the client
    ///  needs the change in output
    /// </summary>
    public class AdapterXmlToJson : XMLMaker, IXmlToJson
    {
        /// <summary>
        /// the Convert Method converts the Xml document to the json string
        /// </summary>
        /// <param name="xDocument"></param>
        /// <returns>json string</returns>
        public string GetData(XDocument xDocument)
        {
            //// var binds the type at runtime
            //// Select is a method from the System.Linq Library which is specially used for IEnumerables
            var serializable = xDocument.Element("Manufacturers").Elements("Manufacturer").Select(m => new Manufacturer
            {
                //// fetching the value from the Attribute and assigning it to the object again
                name = m.Attribute("Name").Value,
                place = m.Attribute("Place").Value
            });
            return JsonConvert.SerializeObject(serializable, Formatting.Indented);
        }
    }
}
