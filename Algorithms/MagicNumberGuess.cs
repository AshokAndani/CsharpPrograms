using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    class MagicNumberGuess
    {
        public static void DriverMethod()
        {
            Console.Write("enter a number : "); int k = Utility.ReadInt();
            int limit = (int)Math.Pow(2,k);
            Console.WriteLine("Imagine a number between 0 and "+limit+" in your mind:");
            int num = search(0, limit);
            Console.WriteLine("Your number is "+num);


        }
        public static int search(int lo,int hi)
        {
            if ((hi - lo) == 1)
                return lo;
            int mid = lo + (hi-lo) / 2;
            Console.Write("is your number less than "+mid+" : ");
            bool flag = bool.Parse(Console.ReadLine());
            if (flag)
                return search(lo,mid);
            else return search(mid,hi);
        }
    }
}
