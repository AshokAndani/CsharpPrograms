using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class BinarySearchWord
    {
        public  void DriverMethod()
        {
            Console.Write("enter the word you want to search : ");
            string word = Console.ReadLine();
            string[] arr = File.ReadAllText("D:/WindowsProjects/ConsoleApp1/ConsoleApp1/sample.txt").Split(" ");
            Array.Sort(arr);
            
            Console.Write("the word is in "+Array.BinarySearch(arr, word)+" index");
        }
    }
}
