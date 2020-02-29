

namespace AddressBook
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.IO;
    public class AddressBookImplementation
    {
       
    /// <summary>
    ///this is the Person Class which will be serialized 
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int zip { get; set; }
        public long PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("FirtsName:   {0}\nLastName:    {1}\n" +
                "PhoneNumber: {2}\nCity:        {3}\nState:       {4}\nZip:         {5}\nAddress:     {6}"
                , FirstName, LastName,PhoneNumber, City,State,zip,Address);
        }

    }
  
}