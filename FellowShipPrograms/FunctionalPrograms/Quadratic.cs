using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Quadratic
    {
        public Quadratic()
        {
            Console.WriteLine("enter the value for a b c to find the root");
            quadratic(Utility.ReadDouble(), Utility.ReadDouble(), Utility.ReadDouble());
        }
        public void quadratic(double a, double b, double c)
        {
            double root1, root2;
            double delta = (b * b) - (4 * a * c);
            if(delta>0)
            {
                root1 = (-b +( Math.Sqrt(delta) / (2 * a)));
                root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("the roots are " + root1 + " and " + root2);
            }
            else if (delta == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("the root is " + root2);
            }
            else if(delta < 0)
            {
                double actual = -b / (2 * a);
                double imaginary = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("real root is " + actual + " and imaginary root is " + imaginary);
            }
        }
    }
}
