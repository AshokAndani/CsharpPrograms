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
            Console.WriteLine(); 
            Console.WriteLine("these are the Prime palindromes and Anagrams");
            for (int i = 0; i < a.Length; i++)
            {
                if (isPalindrome(a[i]) && a[i]>100)
                {
                    for(int j=0;j<a.Length;j++)
                    {
                        if(CheckAnagram(a[i],a[j]) && a[i]!=a[j])
                        {
                            Console.WriteLine(a[i]+" "+a[j]);
                        }
                    }
                }
            }
        }
        public static bool isPalindrome(int arr)
        {
            int t = arr, ex=0;
            while(t>0)
            {
                ex =ex* 10 +( t % 10);
                t /= 10;
            }
            return ex == arr;
        }
        public static bool CheckAnagram(int a,int b)
        {

            char[] arr=a.ToString().ToCharArray();Array.Sort(arr);
            char[] arr1= b.ToString().ToCharArray(); Array.Sort(arr1);
            if (arr.Length != arr1.Length)
                return false;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] != arr1[i])
                    return false;
            }
            return true;
        }
        
    }
}
