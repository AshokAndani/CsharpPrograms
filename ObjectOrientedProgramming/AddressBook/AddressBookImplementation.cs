

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

       
    }
  
}