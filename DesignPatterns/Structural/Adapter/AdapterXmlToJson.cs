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