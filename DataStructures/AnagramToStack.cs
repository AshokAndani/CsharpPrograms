using System;
using DataStructures.Stack;
using DataStructures.UnOrderedList;

namespace DataStructures
{
    class AnagramToStack
    {
      public static void DriverMethod()
        {
            Anagram a = new Anagram();
            AnagramToStack ra = new AnagramToStack();
            
            List<int> prime_list = a.PrimeRange(0,1000);
            List<int> Anagram_list = a.PrimeAnagram(prime_list);
            Stack<int> s = new Stack<int>(Anagram_list.Size());
           //storing anagrams form list to stack
            for(int i=0 ; i< Anagram_list.Size(); i++)
            {
                s.Push(Anagram_list.peek(i));
            }
            Console.WriteLine("Anagrams stored in Stack are: ");
            Console.WriteLine(s);
            //
            Console.WriteLine("displaying Anagreams Reverse : ");
            while(!s.IsEmpty())
            {
                Console.Write(ra.Reverse(s.Pop()) +" ");
            }

        }
        public int Reverse(int n)
        {
            int res = 0;
            while(n>0)
            {
                res = res * 10 + n % 10;
                n /= 10;
            }
            return res;
        }
    }

}
