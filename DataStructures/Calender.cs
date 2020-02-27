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
  public int[,] calender(int m,int y)
        {
            String[] months = {"","January","February","March","April","May","June",
                "July","August","September","October","November","December"};
            int[] days_in_month = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            if (IsLeapYear(y))
                days_in_month[2] = 29;
            //filling the array with the dates
            int[,] res= new int[2,days_in_month[m]+1];
            for(int i=0;i<2;i++)
            {
                for(int j=1;j<res.GetLength(1);j++)
                {
                    if(i==0 && j<=6)res[i, j] = j;
                    if (i == 1) res[i, j] = j;
                    
                }      }
            int d = DayOfWeek(1, m, y);
            char[] week = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };
            //Calender Display Starts from here
            Console.WriteLine(months[m]+" "+y);
            for(int i=0;i<week.Length;i++)
            {
                Console.Write(week[i]+"  ");
            }
            Console.WriteLine();
            for (int i=0;i<d;i++)
            {
                Console.Write("{0}  ",' ');
            }

            for(int i=1;i<=days_in_month[m];i++)
            {
                Console.Write("{0,2} ",i);
                if ((i+d) % 7 == 0) Console.WriteLine();
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
