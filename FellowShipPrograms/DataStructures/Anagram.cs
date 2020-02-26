using System;
using System.Text;
using DataStructures.UnOrderedList;

namespace DataStructures
{
    class Anagram
    {
      public bool IsAnagram(int m,int n)
        {
            char[] ch = m.ToString().ToCharArray(); Array.Sort(ch);
            char[] ch1 = n.ToString().ToCharArray();Array.Sort(ch1);
            if (ch1.Length != ch.Length)
                return false;
            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i] != ch1[i])
                    return false;
            }
            return true;
        }
        
       public List<int> PrimeRange(int m, int n)
       {
            PrimeNumber2Dimension pm = new PrimeNumber2Dimension();
            List<int> list = new List<int>();
            for(int i=m;i<=n;i++)
            {
                if (pm.IsPrime(i))
                    list.Append(i);
            }
            return list;
       }
        public List<int> PrimeAnagram(List<int> p)
        {
            int[] pr = p.ToArray();
            List<int> l = new List<int>();
            for (int i = 0; i < pr.Length; i++)
            {
                for (int j = 0; j < pr.Length; j++)
                {
                    if (IsAnagram(pr[i], pr[j]) && pr[i] != pr[j])
                    {
                        if (l.IsEmpty())
                        {
                            l.Append(pr[i]);
                        }
                        else
                        {
                            if (!l.Search(pr[i])) l.Append(pr[i]);
                        }
                    }
                }
            }
            return l;
        }
        public int[,] Anagrams(List<int> prime,List<int> anagram)
        {
            int[,] arr = new int[2, prime.Size()];
            Console.WriteLine("number of Prime numbers : "+prime.Size());
            Console.WriteLine("Number of Anagram numbers : " + anagram.Size());

            //filling 1st dimension with anagrams
            for (int i=0;i<anagram.Size();i++)
            {
                arr[0, i] =anagram.peek(i);
            }
        
            //removing anagrams from prime list
            for(int i=0;i<anagram.Size();i++)
            {
                if (prime.Search(anagram.peek(i)))
                    prime.Remove(anagram.peek(i));
            }
           
            //setting non-anagrams to 2d-array
            for(int i=0;i<arr.GetLength(1);i++)
            {
                arr[1, i] = prime.peek(i);
            }
            return arr;
        }
        public void Display(int[,] arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                if(i==0)Console.WriteLine("Anagrams....");
                else if (i == 1) Console.WriteLine("non-Anagram Primes");
                for(int j=0;j< arr.GetLength(1);j++)
                {
                   if(arr[i,j]!=0) Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void DriverMethod()
        {
            Anagram n = new Anagram();
            Console.Write("Enter the  low range: ");
            int low = int.Parse(Console.ReadLine());
            Console.Write("Enter the High range: ");
            int high = int.Parse(Console.ReadLine());
            List<int> prime = n.PrimeRange(low,high);
            List<int> anagram = n.PrimeAnagram(prime);
            int[,] arr = n.Anagrams(prime, anagram);
            n.Display(arr);
        }

    }
}
