using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ToBinary
    {
        public ToBinary()
        {
            Console.Write("enter the number for its binary form: ");
            Console.WriteLine(Binary(Utility.ReadInt()));
        }
        public int Binary(int n)
        {
            string st = "";
            while(n>0)
            {
                st = n % 2 + st;
                n /= 2;
            }
             return int.Parse(st);
        }
    }
}
