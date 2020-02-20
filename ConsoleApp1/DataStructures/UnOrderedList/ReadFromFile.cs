using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ConsoleApp1.DataStructures.UnOrderedList;

namespace ConsoleApp1.DataStructures.UnOrderedList
{
    class ReadFromFile
    {
        public static void DriverMethod()
        {
            
            Console.WriteLine("enter the file fileName: ");
            string FilePath = Path.GetFullPath(Console.ReadLine());
            String[] array = File.ReadAllText(FilePath).Split(" ");
            List list=ArrayToList(array);
            Console.Write("enter the word : ");
            string word = Console.ReadLine();
            Console.WriteLine("Before....Processing_______________________________________________");
            String content = File.ReadAllText(FilePath);
            Console.WriteLine(content);
            if (list.Search(word))
            {
                Console.WriteLine(word + " is found in the file so removing it..");
                list.Remove(word);
                
            }
            else
            {
                Console.WriteLine(word + " is not found so adding it to List___- ");
                list.Append(word);
            }
            Console.WriteLine("after Processing____________________________________________________");
            Console.WriteLine(list);
            String[] arr = ListToArray(list);
            File.WriteAllText(FilePath,string.Join(" ",arr));
            Console.WriteLine("This is from final File:....___________________________________________");
            Console.WriteLine(File.ReadAllText(FilePath));
        }
        public static List ArrayToList(string[] arr)
        {
            List list = new List();
            foreach (string content in arr)
                list.Append(content);
            return list;
        }
        public static string[] ListToArray(List list)
        {
            String[] arr= new string[list.Size()];
            for(int i=0;i<list.Size();i++)
            {
                arr[i] = (String)list.peek(i);
            }
            return arr;
        }
    }
}
