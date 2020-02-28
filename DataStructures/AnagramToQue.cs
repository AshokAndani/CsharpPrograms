using System;
using System.Text;
using DataStructures.UnOrderedList;

namespace DataStructures
{
    class AnagramToQue
    {
        public static void DriverMethod()
        {
            Anagram a = new Anagram();
            //this method gives primenumbers in a range in a List
            List<int> Prime_list = a.PrimeRange(0,1000);

            //this method takes list of Prime numbers and returns list of anagrams
            //from the Prime numbers list
            List<int> Anagram_List = a.PrimeAnagram(Prime_list);

            //filling Que with Prime Anagrams from List
            Queue<int> q = new Queue<int>(Anagram_List.Size());
            for(int i=0; i<Anagram_List.Size();i++ )
            {
                q.Enqueue(Anagram_List.peek(i));
            }

            //Displaying The Que filled with anagrams from 0 to 1000
            Console.WriteLine("Anagrams Stored in Que Are: ");
            Console.WriteLine(q);

        }
        
    }
}
