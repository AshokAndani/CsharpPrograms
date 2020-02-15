using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DayOfWeek
    {
        public DayOfWeek()
        {
            Console.WriteLine("enter the month date and year..");

            Console.WriteLine(GetWeekNumber(Utility.ReadInt(), Utility.ReadInt(), Utility.ReadInt()));
        }
        public String GetWeekNumber(int d,int m,int y)
        {
            String[] array = {"Sunday","Monday","Tuesday","Wednesday","Thursday",
                    "Friday","Saturday" };
            int yf = y - (14 - m) / 12;
            int x = yf + yf / 4 - yf / 100 + yf / 400;
            int mf = m + 12 * ((14 - m) / 12) - 2;
            return array[((d + x + 31 * (mf / 12)) % 7)];
        }


    }
}
