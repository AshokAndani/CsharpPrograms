using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Algorithms
{
    class RegexPatternMessage { 
    
        public static void DriverMethod()
        {
            String Message = "Hello <<name>>, We have your full name as <<full name>> in our system." +
                " your contact number is 91-xxxxxxxxxx . " +
                "Please,let us know in case of any clarification Thank you BridgeLabz 01-01-2016.";
            Console.WriteLine(Message);
            String namePattern = "^([a-zA-Z]{3,20})+$";
            string phonePattern = "^([0-9]{2})+-([0-9]{10})+$";
            String Full_namePattern = "^([a-zA-z-_]{3,10})+$";
            string name, phone, Full_name = "";
            while (true)
            {
                Console.WriteLine("enter the name");
                name = Console.ReadLine();
                if (IsValid(name, namePattern))
                {
                    Console.WriteLine("enter the 2nd name");
                    Message = Message.Replace("<<name>>", name);
                    Full_name = Console.ReadLine();
                    if (IsValid(Full_name, Full_namePattern))
                    {
                        Console.WriteLine("enter the phone number");
                        Message = Message.Replace("<<full name>>", name + " " + Full_name);
                        phone = Console.ReadLine();
                        if (IsValid(phone, phonePattern))
                        {
                            Message = Message.Replace("91-xxxxxxxxxx", phone);
                            Message = Message.Replace("01-01-2016", DateTime.Today.ToString("dd-MM-yyyy"));
                            Console.WriteLine(Message);
                            break;
                        }
                        else Console.WriteLine("Entered Phone number is not valid.!");

                    }
                    else Console.WriteLine("Entered 2nd name is not valid.!");

                }
                else Console.WriteLine("Entered name is not valid.!");

            }
        }
        public static bool IsValid(String value,String pattern)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            return Regex.IsMatch(value,pattern);
        }


    }
}
