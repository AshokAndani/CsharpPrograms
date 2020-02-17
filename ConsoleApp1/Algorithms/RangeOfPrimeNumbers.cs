using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RangeOfPrimeNumbers
    {
        public static bool isPrime(int n)
        {
            int count = 1, i = 2;
            while (n / 2 >= i)
            {
                if (n % i == 0)
                { count += 1; }
                if (count >= 2)
                { return false; }
                i++;
            }
            return true;
        }
        public static int PrimeCount(int s,int l)
        {
            int count = 0;
            for(int i=s;i<=l;i++)
            {
                if (isPrime(i))
                { count++; }
            }
            return count;
        }
        public static int[] PrimeRange(int s,int l)
        {
            int[] arr = new int[PrimeCount(s,l)];
            int i = 0;
            while(s<l)
            {
                if(isPrime(s))
                {
                    arr[i++] = s ;
                }
                s++;
            }
            return arr;

        }
        public static void DriverMethod()
        {
            Console.Write("enter the min range : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the Max range : ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] a = PrimeRange(min, max);
            Console.WriteLine("the Prime numbers in the range are: ");
            foreach(int n in a)
            {
                Console.Write(n + " ");
            }
            
        }
    }
}
