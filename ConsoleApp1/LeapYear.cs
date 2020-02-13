using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LeapYear
    {
        public LeapYear()
        {
            Console.WriteLine("enter the year to check..:");
            int year = (Convert.ToInt32(Console.ReadLine()));
            IsLeap(year);
        }
        public void IsLeap(int n)
        {
            if ((n % 400 == 0) || (n % 100 != 0 && n % 4 == 0))
                Console.WriteLine(n + " is Leap year...!");
            else
                Console.WriteLine(n+" is not a Leap year.....!");
        }
    }
}
