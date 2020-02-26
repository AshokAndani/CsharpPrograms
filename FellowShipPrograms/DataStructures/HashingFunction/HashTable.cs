using System;
using System.Text;
using DataStructures.OrderedLists;
using System.IO;
using DataStructures.UnOrderedList;

namespace DataStructures.HashingFunction
{
    class HashTable
    {

        public static void DriverMethod()
        {
            //taking the File Path
            Console.WriteLine("Enter the FilePath");
            string FilePath = Path.GetFullPath(Console.ReadLine());
            string content = File.ReadAllText(FilePath);
            
            //pure integers that are to be stored to hashtable
            int[] fileContent = FileToArray(content);

            //storing into hashtable
            OrderedList[] slot = FillHashtable(fileContent);

            //now searching the user entered value
            Console.Write("Enter the number to Search: ");
            int number_to_Search = int.Parse(Console.ReadLine());
            if(search(slot,number_to_Search))
                Console.WriteLine(number_to_Search+" Number is Found in the File");
            else Console.WriteLine(number_to_Search+" Number is not found in " +
                "the file \n");
            DisplayHashTable(slot);
            


           
        }
        public static OrderedList[] FillHashtable(int[] file)

        {
            OrderedList[] slot = new OrderedList[11];
            //creating Objects of Ordered List
            for (int i = 0; i < slot.Length; i++)
            {
                slot[i] = new OrderedList();
            }
            //Filling the Objects
            for (int i = 0; i < file.Length; i++)
            {
                int Index = file[i] % 11;
                slot[Index].add(file[i]);
            }
            return slot; 
        }
        
        public static bool search(OrderedList[] slot,int number)
        {
            int Index = number % 11;
            return slot[Index].Search(number);
        }
        public static void DisplayHashTable(OrderedList[]slot)
        {
            Console.WriteLine("Elements at each index.....");
            for(int i=0;i<slot.Length;i++)
            {
                Console.Write(i+" --> "+slot[i] +"\n");
            }

        }
        public static int[] FileToArray(String file)
        {
            string[] array = file.Split(" ");
            int number;
            List<int> list = new List<int>();
            for(int i=0;i<array.Length;i++)
            {
                if(int.TryParse(array[i],out number))
                {
                    list.Append(number);
                }
            }
            int[] result = new int[list.Size()];
            for(int i=0;i<result.Length;i++)
            {
                result[i] = list.peek(i);
            }
            return result;
              
        }
    }
}
