using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Utility
    {
        public static void Print(String value)
        {
            Console.Write(value);
        }
        public static void Println()
        {
            Console.WriteLine();
        }
        public static void Println(String value)
        {
            Console.WriteLine(value);
        }
        public static int ReadInt()
        {

            return (Convert.ToInt32(Console.ReadLine()));
        }
        public static double ReadDouble()
        {
            return (Convert.ToDouble(Console.ReadLine()));
        }
        public static String ReadString()
        {
            String value = Console.ReadLine();
            String[] arr = value.Split(" ");
            return arr[0];
        }
        public static String ReadStrings()
        {
            return Console.ReadLine();
        }
        public static void print(String value)
        {
            Console.WriteLine(value);
        }
        public bool readBoolean()
        {
            String Value = Console.ReadLine();
            if (Value == "true")
                return true;
            else if (Value == "false")
                return false;
            else
            {
                Console.WriteLine("invlid entry...");
                throw new FormatException("invalid");
            }
        }
        public char ReadChar()
        {
            String value = Console.ReadLine();
            String[] arr=value.Split(" ");
            return arr[0].ToCharArray().ElementAt(0);
        }

    }
}
