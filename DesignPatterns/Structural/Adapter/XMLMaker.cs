// <copyright file="XMLMaker.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Adapter
{
    using System;
    using System.Xml.Linq;
    using System.Linq;
    /// <summary>
    /// this class is the main or source which is strictly not be modified
    /// </summary>
    public class XMLMaker
    {
        /// <summary>
        ///  this method gives the xml format by taking the list as input
        /// </summary>
        /// <returns></returns>
        public XDocument GetXml()
        {
            var list = ManufacturerData.GetManufacturers();
            XElement xElement = new XElement("Manufacturers");
            foreach (Manufacturer m in list)
            {
                XElement e= new XElement("Manufacturer", new XAttribute("Name", m.name), new XAttribute("Place", m.place));
                xElement.Add(e);
            }
            XDocument xDocument = new XDocument();
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
