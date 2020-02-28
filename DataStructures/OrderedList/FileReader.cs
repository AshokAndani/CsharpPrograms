using System;
using System.IO;
using DataStructures.OrderedList;

namespace DataStructures.OrderedList
{
    class FileReader
    {
       
       public static void DriverMethod()
        {

            //this is to filter the user entered path to exact path
            Console.Write("enter the File path : ");
            String FilePath = Path.GetFullPath(Console.ReadLine());
            String value = File.ReadAllText(FilePath);

            // creating a new OrderedList 
            OrderedList list = new OrderedList();

            //splitting the string into array in order to push it to list

            string[] array = value.Split(" ");
            Console.WriteLine("before Processing the file content_______________");
            Console.WriteLine(value);
            for (int i = 0; i < array.Length; i++)
            {
                int num;
                if (int.TryParse(array[i],out num))
                {
                    list.add(num);
                }
            }
            Console.WriteLine("processed content using OrderedList>>>>>>");
            Console.WriteLine(list);

            // now re-Writing the file with ordered List
            string processed_string = "";
            for(int i=0;i<list.size();i++)
            {
                processed_string +=" "+(int)list.peek(i);
            }
            File.WriteAllText(FilePath, processed_string);
            Console.WriteLine("file content after processing_____________>>>");
            Console.WriteLine(File.ReadAllText(FilePath));
        }
        

    }
}
