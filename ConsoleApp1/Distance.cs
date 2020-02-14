using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Distance
    {
        public Distance()
        {
            Utility.print("enter the Point x and y to Calculate the distance:..");
            distanceCalculation(Utility.ReadInt(), Utility.ReadInt());
        }
        public void distanceCalculation(int m,int n)
        {
            double value = Math.Sqrt((m * m)+ (n * n));
            Console.WriteLine("the distance from (0,0) to (" + m + "," + n + ") is : " + value);
        }
    }
}
