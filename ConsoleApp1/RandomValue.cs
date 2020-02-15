using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RandomValue
    {
        static Random r = new Random();
        public static int IntRange(int m,int n)
        {
            
            return r.Next(m,n);
        }
        public static int Int()
        {
            return r.Next();
        }
        public static char SmallChar()
        {
            char[] ch = new char[27];
            char s = 'a';
            for(int i=1;i<=26;i++)
            {
                ch[i] = s++;
            }
            return ch[IntRange(1, 27)];
        }
        public static char bigChar()
        {
            char[] ch = new char[27];
            char s = 'A';
            for (int i = 1; i <= 26; i++)
            {
                ch[i] = s++;
            }
            return ch[IntRange(1, 27)];

        }
        public static string RandomString(int length)
        {
            string word = "";
            while(length>0)
            {
                word += SmallChar();
                length--;
            }
            return word;
        }
        public static string RandomString()
        {
            int length = IntRange(0,10);
            string word = "";
            while (length > 0)
            {
                word=word+SmallChar();
                length--;
            }
            return word;

        }
    }
}
