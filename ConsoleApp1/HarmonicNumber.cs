using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HarmonicNumber
    {
        public HarmonicNumber()
        {
            Console.WriteLine("enter the nth value for Harmonic Number:");
            int h = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("the nth harmonic value of "+h+" is "+Harmonic(h));
        }
        public double Harmonic(int n)
        {
            double value = 0, i = 1;
            while(i<=n)
            {
                value +=( 1 / i++);
            }
            return value;
        }
    }
}
