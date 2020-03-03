/// --------------------------------------------------------------------------------------------------------------------
/// <copyright file=AddressBookImplementation.cs" company="Bridgelabz">
///   Copyright © 2020 Company="BridgeLabz"
/// </copyright>
/// <creator name="ASHOKKUMAR"/>
//// --------------------------------------------------------------------------------------------------------------------

namespace AddressBook
{
    /// <summary>
    /// this is the implementation of addressBook where Methods are written here 
    /// </summary>
    public class AddressBookImplementation
    {
    /// <summary>
    /// this () adds a new Person to the json file
    /// </summary>

    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

public void AddPerson()
        {
            //////taking input from the user
            Console.Write("Enter firstName: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter lastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter phoneNumber: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.Write("Enter zip: ");
            string zip = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            //////initializing the Object with user input
            Person p = new Person()
            {
                firstName = firstName,
                lastName = lastName,
                phoneNumber = phoneNumber,
                zip = zip,
                state = state,
                city = city,
                address = address
            };
            //////fething string from the file
            string jsonfile = File.ReadAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json");

            //////now creating a List to Store the Person objects
            List<Person> persons = new List<Person>();
            if (jsonfile.Length != 0)
            {
                persons = (List<Person>)JsonConvert.DeserializeObject<List<Person>>(jsonfile);
            }

            persons.Add(p);

            ////serializing the object into json format
            string serialize = JsonConvert.SerializeObject(persons);

            ////now json format is writing into a .json file
            File.WriteAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json", serialize);
            return;
        }

        /// <summary>
        /// this method is used to delete the person details
        /// </summary>
        public void Delete()
        {

            ////getting the name of the person to delete the information
            Console.WriteLine("Enter the Name of the Person");
            string firstName = Console.ReadLine();

            //////this will read json file
            string jsonfile = File.ReadAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json");
 
            //////deserializing the json content
            List<Person> p;
                
            p = (List<Person>)JsonConvert.DeserializeObject<List<Person>>(jsonfile);
            Person[] obj = p.ToArray();
            p = new List<Person>();
            foreach (Person x in obj)
            {
                if (!x.firstName.Equals(firstName))
                {
                    p.Add(x);
                }
            }

            ////serializing the List of Person objects
            string serialize = JsonConvert.SerializeObject(p);

            ////Re-writing the json file with deletion
            File.WriteAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json", serialize);
            return;
        
}


        /// <summary>
        /// this () edits the details given by the Person
        /// </summary>
        public void Edit()
        {

            ////this is to choose the Person From the List
            Console.WriteLine("Enter the Name of the Person");
            string firstName = Console.ReadLine();
           
            ////this line is to show the user to select attribute represented character
            Console.Write("choose the detail you want to change..\n lastName(L)\t" +
                "address(A)\tcity(C)\tstate(S)\tphoneNumber(P)\tzip(Z)\n");
            
            ////extracting the json contents in the form of string
            string jsonfile = File.ReadAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json");

            ////initializing the List to use it multiples times further
            List<Person> p;

            ////this will convert the json string to object
            p = (List<Person>)JsonConvert.DeserializeObject<List<Person>>(jsonfile);
                 ////iterating the list to check catch the required object
            foreach (Person x in p)
            {
                if (x.firstName.Equals(firstName))
                {
                    char ch = Console.ReadLine()[0];
                    Console.Write("Enter the replacing detail: ");
                    string replace = Console.ReadLine();                    switch (ch)
                    {
                        case 'L':
                            Console.WriteLine(x.lastName + " is replaced with " + replace); 
                            x.lastName = replace;
                            break;
                        case 'A':
                            Console.WriteLine(x.address + " is replaced with " + replace);
                            x.address = replace; 
                            break;
                        case 'C':
                            Console.WriteLine(x.city + " is replaced with " + replace);
                            x.city = replace; 
                            break;
                        case 'S':
                            Console.WriteLine(x.state + " is replaced with " + replace);
                            x.state = replace; 
                            break;
                        case 'P':
                            Console.WriteLine(x.phoneNumber + " is replaced with " + replace);
                            x.phoneNumber = replace; 
                            break;
                        case 'Z':
                            Console.WriteLine(x.zip + " is replaced with " + replace);
                            x.zip = replace; 
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                }
            }
            
            string serialize = JsonConvert.SerializeObject(p);
            
            File.WriteAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json", serialize);

            return;
        }

        /// <summary>
        /// this method display the json file content
        /// </summary>
        public void DisplayJson()
        {
}
            ////fetching the json file to deserialize
            string jsonfile = File.ReadAllText(@"D:\WindowsProjects\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json");

            ////deserializing the json state
            List<Person> p = (List<Person>)JsonConvert.DeserializeObject<List<Person>>(jsonfile);

            ////printing the object contents
            foreach (Person x in p)
            {
                Console.WriteLine(x + "\n");
            }
        }
    }

    /// <summary>
    /// this is the Person Class which will be serialized 
    /// </summary>
    public class Person
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phoneNumber;

        /// <summary>
        ///  this method represents the string representation of person object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("FirtsName:   {0}\nlastName:    {1}\n" +
                "phoneNumber: {2}\ncity:        {3}\nstate:       {4}\nzip:         {5}\naddress:     {6}"
                , firstName, lastName,phoneNumber, city,state,zip,address);
        }
    
}       
}
}
