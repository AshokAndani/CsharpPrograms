using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Binary
    {        public static string nibbleSwap(string bin)
        {
            string number = "";
            for(int i=bin.Length-4;i<=bin.Length-1;i++)
            {
                number=number+ bin[i];
            }
            for(int i=0;i<4;i++)
            {
                number += bin[i];
            }

            return number;
        }
        public static int BinaryToDecimal(String bin)
        {
            int a = int.Parse(bin);int n = 0, p = 1;
            while(a>0)
            {
                int d = a % 10;
                n += d * p;
                p *= 2;
                a = a / 10;
               
            }
            return n;
        }

        public static bool PowerOf2(int n)
        {
            int i = 1;
            while(n/2>i)
            {
                if(Math.Pow(2,i++)==n)
                {
                    return true;
                }
                
            }
            return false;
        }
        public static void Driver()
        {
            Console.Write("enter number for its Binay..:");
            int num = Utility.ReadInt();
            string bin = ToBinary.Binary(num);
            Console.WriteLine("the Binary value " + num + " is : " + bin);
            string swappedbin = nibbleSwap(bin);
            Console.WriteLine("binary value got after swapping : " +swappedbin);
            int fin=BinaryToDecimal(swappedbin);
            Console.WriteLine("decimal value of swapped binary is : " + fin);
            if(PowerOf2(fin))
            {
                Console.WriteLine("the number is Power of 2");
            }
            else
            {
                Console.WriteLine("the number is not Power of 2");
            }
        }

    }
    



}
