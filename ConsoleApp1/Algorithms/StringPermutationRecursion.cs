using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StringPermutationRecursion
    {
        public static string swap(string s,int i,int j)
        {
            char t;
            char[] ch = s.ToCharArray();
            t = ch[i];
            ch[i] = ch[j];
            ch[j] = t;
            String n = new String(ch);
            return n;
        }
        public static void permutation(List<string> lst,string st,int l,int h)
        {

            if (l == h)
                lst.Add(st);
            else
            {
                for (int i = l; i <= h; i++)
                {
                    st = swap(st, l, i);
                    permutation(lst,st, l + 1, h);
                    st = swap(st, l, i);
                }
            }
        }
        public static List<String> DriverMethod(String st)
        {
            int n = st.Length;
            List<String> lst = new List<String>();
            permutation(lst,st, 0, n-1);
            
            return lst;

        }

    }
}
