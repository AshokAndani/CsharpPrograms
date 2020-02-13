using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PowerOf2
    {     
        public PowerOf2()
    {
        Console.WriteLine("enter the power for power of 2");
        int power = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("2 power of "+power+" is " + Power(power));
    }
    public int Power(int n)
        {
            int value = 1;
            while(n>0)
            {
                value *= 2; n--;
            }
            return value;
        }
    }
}
