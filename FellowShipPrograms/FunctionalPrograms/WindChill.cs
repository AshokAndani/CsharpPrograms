using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class WindChill
    {
        public WindChill()
        {
            Utility.print("enter the temperature in °F and velocity m/h of wind to calculate WindChill index:");
            Console.WriteLine("the WindChill index is : " + WindChillIndex(Utility.ReadDouble(), Utility.ReadDouble()));

        }
        public double WindChillIndex(double t, double v)
        {
            return (35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16));
        }
    }
}
