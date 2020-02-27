using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Calender
    {
        public bool IsLeapYear(int n)
        {
            if ((n % 400 == 0) || ((n % 100 != 0) && (n % 4 == 0)))
                return true;
            return false;
        }
 public int DayOfWeek(int d,int m,int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }
        public void DisplayArray(int[,] a)
        {
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                      if(a[i,j]!=0 && j!=0)  Console.Write(a[i,j]+" ");
                    if (i!=1 && j == 0) Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
