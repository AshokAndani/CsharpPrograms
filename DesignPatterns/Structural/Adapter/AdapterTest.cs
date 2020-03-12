// <copyright file="AdapterTest.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.Structural.Adapter
{
    using System;
    using System.Xml.Linq;

    /// <summary>
    ///  this class simulates the adapter Pattern
    /// </summary>
    public class AdapterTest
    {
        /// <summary>
        /// Written the whole in the Constuctor
        /// </summary>
        public AdapterTest()
        {
            //// XmlMaker is responsible to convert the List of Objects to Xml format
            XMLMaker make = new XMLMaker();
            Console.WriteLine("this is the XML file generating code which is legacy which cannot be deleted");
            //// XmlMaker has a GetXml() which takes the list as and converts into xml format
            XDocument document = make.GetXml();
            Console.WriteLine( document+"\n this is json file which is required for the customer_________________" );
            
            //// printing the json which is according to client without any change in source code
            //// here calling the AdapterXmlToJson using its super interface
            IXmlToJson xmlToJson = new AdapterXmlToJson();

            //// Adapter class contains a Convert method which converts the xml format to json string
            Console.WriteLine(xmlToJson.GetData(document)) ;
        }
    }
}
