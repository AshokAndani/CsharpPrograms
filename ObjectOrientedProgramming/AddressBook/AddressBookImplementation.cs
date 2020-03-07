/// --------------------------------------------------------------------------------------------------------------------
/// <copyright file=AddressBookImplementation.cs" company="Bridgelabz">
///   Copyright © 2020 Company="BridgeLabz"
/// </copyright>
/// <creator name="ASHOKKUMAR"/>
//// --------------------------------------------------------------------------------------------------------------------

namespace AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// this is the implementation of addressBook where Methods are written here 
    /// </summary>
    public class AddressBookImplementation
    {
        public static string path = @"C:\Users\yempc73\Desktop\FellowShip\ObjectOrientedProgramming\ObjectOrientedProgramming\AddressBook\AddressBook.json";
    /// <summary>
    /// this () adds a new Person to the json file
    /// </summary>
        public void AddPerson()
        {
            ////fething string from the file
            string jsonfile = File.ReadAllText(path);

            ////validating the jsonfile not to be Empty
            List<Person> persons;
            if (jsonfile.Length != 0)
            {
                persons = (List<Person>)JsonConvert.DeserializeObject<List<Person>>(jsonfile);
            }
            else persons = new List<Person>();
            ////taking input from the user
            Console.Write("Enter firstName: ");
            string firstName = Console.ReadLine();

            //// checking wether the name exists
            foreach (Person tp in persons)
            {
                if (tp.firstName.Equals(firstName))
                {
                    Console.WriteLine("details with this name already exists...!");
                    return;
                }
            }

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

            



            persons.Add(p);

            ////serializing the object into json format
            string serialize = JsonConvert.SerializeObject(persons);

            ////now json format is writing into a .json file
            File.WriteAllText(path, serialize);
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
            string jsonfile = File.ReadAllText(path);

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
            File.WriteAllText(path, serialize);
            return;
        }

        /// <summary>
        /// this () edits the details given by the Person
        /// </summary>
        public void Edit()
        {
            ////extracting the json contents in the form of string
            string jsonfile = File.ReadAllText(path);

            //// validating the json file
            if (jsonfile.Length < 1)
            {
                Console.WriteLine("AddressBook is Empty Please Add Details");
                return;
            }

            List<Person> p = (List<Person>)JsonConvert.DeserializeObject<List<Person>>(jsonfile);

            ////name suggestions for user Interface
            Console.WriteLine("Name Suggestions");
            foreach (Person person in p)
            {
                Console.Write("\""+person.firstName+"\" ");
            }

            ////this is to choose the Person From the List
            Console.WriteLine("\nEnter the Name of the Person to edit");
            string firstName = Console.ReadLine();
           
            ////this line is to show the user to select attribute represented character
            Console.Write("choose the detail you want to change..\n lastName(L)\t" +
                "address(A)\tcity(C)\tstate(S)\tphoneNumber(P)\tzip(Z)\n");
            
            ////iterating the list to check catch the required object
            foreach (Person x in p)
            {
                if (x.firstName.Equals(firstName))
                {
                    char ch = Console.ReadLine()[0];
                    Console.Write("Enter the replacing detail: ");
                    string replace = Console.ReadLine();
                    switch (ch)
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
            
            File.WriteAllText(path, serialize);

            return;
        }

        /// <summary>
        /// this method display the json file content
        /// </summary>
        public void DisplayJson()
        {
            ////fetching the json file to deserialize
            string jsonfile = File.ReadAllText(path);

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