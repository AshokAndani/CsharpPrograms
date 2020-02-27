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
