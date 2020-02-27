using System;
using DataStructures.UnOrderedList;
using DataStructures.OrderedLists;
using DataStructures.Stack;
using DataStructures.Deque;
using DataStructures.Queue;
using DataStructures.HashingFunction;

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
                "Enter 6 for BinarySearchTree \n" +
                "Enter 7 for HashFunction\n" +
                "Enter 8 for PrimeNumber2Dimension \n" +
                "Enter 9 for Anagrams in array\n" +
                "Enter 10 for AnagranToStack\n" +
                "Enter 11 for AnagranToQue\n" +
                "Enter 12 for Calender");
            
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
                case 7: HashTable.DriverMethod(); break;
                case 8:PrimeNumber2Dimension.DriverMethod(); break;
                case 9:Anagram.DriverMethod(); break;
                case 10:AnagramToStack.DriverMethod(); break;
                case 11:AnagramToQue.DriverMethod(); break;
                case 12:Calender.DriverMethod(); break;
                case 13:WeeksInQue.DriverMethod(); break;
                default: Console.WriteLine("invalid Entry"); ; break;
                }
        }
    }
}
