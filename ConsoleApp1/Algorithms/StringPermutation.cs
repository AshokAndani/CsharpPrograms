using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    class StringPermutation
    {
        public string swap(string s,int i,int j)
        {
            char t;
            char[] ch = s.ToCharArray();
            t = ch[i];
            ch[i] = ch[j];
            ch[j] = t;
            String n = new String(ch);
            return n;
        }
        public void permutation(string st,int l,int h)
        {
            if (l == h)
                Console.WriteLine(st);
            else
            {
                for(int i=l;i<=h;i++)
                {
                    st = swap(st,l,i);
                    permutation(st,l+1,h);
                    st = swap(st,l,i);
                }
            }
        }
        public void DriverMethod()
        {
            Console.Write("enter the String word : ");
            String word = Console.ReadLine();
            int n = word.Length;
            permutation(word, 0, n-1);

        }

    }
}
