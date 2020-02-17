using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AnagramDetection
    {
        public static bool IsAnagram(String word, string word1)
        {
            if (word.Length != word1.Length)
                return false;
            char[] c1 = word.ToCharArray(); Sorting.BubbleSortChar(c1);
            char[] c2 = word1.ToCharArray(); Sorting.BubbleSortChar(c2);
            for(int i=0;i<c1.Length;i++)
            {
                if (c1[i] != c2[i])
                    return false;
            }
            return true;


        }
        public static void DriverMethod()
        {
            Console.Write("enter the 1st Word: ");
            string word=Console.ReadLine();
            Console.Write("enter the 2nd Word: ");
            string word1 = Console.ReadLine();
            Console.Write(IsAnagram(word, word1));
        }
    }
}
