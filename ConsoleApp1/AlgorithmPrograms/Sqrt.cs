using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sqrt
    {
        public Sqrt()
        {
            Console.Write("enter the number for its SquareRoot:");
            Console.WriteLine(Sqroot(Utility.ReadDouble()));
        }
        public double Sqroot(double t)
        {
            double c = t;
            double epsilon = 1e-15;
            while(Math.Abs(t-c/t)>epsilon*t)
            {
                t = (c / t + t) / 2;
            }
            return t;
        }
    }
}
