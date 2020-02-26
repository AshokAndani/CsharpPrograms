using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Factorial
    {
        public Factorial()
        {
            Console.WriteLine("enter the Number for factorial..:      ");
            int number = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("the factorial of " + number + " is " + Fact(number));

        }
        public int Fact(int n)
        {
            int value = 1;
            while(n>0)
            {
                value *= n--;
            }
            return value;
        }
    }
}
