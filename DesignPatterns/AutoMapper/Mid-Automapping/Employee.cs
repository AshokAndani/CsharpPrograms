// <copyright file="Employee.cs" company="BridgeLabz">
//     BridgeLabs. All rights reserved.
// </copyright>
// <author>ASHOKKUMAR</author>
namespace DesignPatterns.AutoMapper.Mid_Automapping
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    ///  this class copies the Customer class Fields using the auto-mapper
    /// </summary>
    public class Employee
    {
        public string Name;
        public string HomeTown;
        public int CurrentAge;

        /// <summary>
        /// represent the string format of this class Object
        /// </summary>
        /// <returns>string representation</returns>
        public override string ToString()
        {
            return string.Format("{0}--------->\nName: {1}\nHomeTown: {2}\nCurrentAge: {3}",this.GetType().Name, this.Name,this.HomeTown,this.CurrentAge);
        }
    }
}
