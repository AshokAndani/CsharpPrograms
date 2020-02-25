using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    class StringPermutationIterative
    {
        public static List<string> DriverPermute(string st)
        {
            List<String> lst = new List<string>();
            lst.Add("ABC");
            
            
             Permutation(lst,st);
            return lst;
        }
        public static void swap(char[] a,int i,int j)
        {
            char ch = a[i];
            a[i] = a[j];
            a[j] = ch;
        }
        public static void Permutation(List<string> lst,string s)
        {
            char[] charr = s.ToCharArray();
            int[] p = new int[s.Length];
            int i = 1,j = 0;
            while(i<s.Length)
            {
                if (p[i]<i)
                {
                    j = (i%2) * p[i];
                    swap(charr, i, j);
                    lst.Add(new string(charr));
                    p[i]++;i = 1;
                }
                else
                {
                    p[i++] = 0;
                }

            }
        }
    }
}
