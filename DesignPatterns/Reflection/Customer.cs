using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Reflection
{
        public class Customer
    {
        public string FirstName;
        public string LastName;
        public int age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }
        public bool under18;
        
        public string GetFullName(string firstname, string lastName)
        {
            return firstname + " " + lastName;
        }
        public Customer() { }
        public Customer(String name, String city)
        { }
    }
}
