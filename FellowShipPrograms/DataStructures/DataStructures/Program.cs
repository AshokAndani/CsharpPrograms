using System;
using DataStructures.UnOrderedList;
using DataStructures.OrderedList;
using DataStructures.Stack;
using DataStructures.Deque;
using DataStructures.Queue;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the main Class from which every class objects are created
            Console.WriteLine("Enter 1 for UnOrderedList.\nEnter 2 for OrderedList " +
                "\n" +
                "Enter 3 for BalancedParantheses \n" +
                "Enter 4 for CashCounter \n" +
                "Enter 5 for PalidromeCheck \n" +
                "Enter 6 for BinarySearchTree");
            
            int number = int.Parse(Console.ReadLine());
            //by using a static method called DriverMethod to invoke the particular class
            switch(number)
                {
                case 0: new Test(); break;
                case 1: ReadFromFile.DriverMethod(); break;
                case 2: FileReader.DriverMethod(); break;
                case 3: BalancedParentheses.DriverMethod(); break;
                case 4:new CashCounter(); break; 
                case 5: PalindromeChecker.DriverMethod(); break;
                case 6:BinarySearchTree.DriverMethod(); break;
                default: Console.WriteLine("invalid Entry"); ; break;
                }
        }
    }
}
