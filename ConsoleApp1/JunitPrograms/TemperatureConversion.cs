using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TemperatureConversion
    {
        public TemperatureConversion()
        {
            Console.Write("enter the TEMPERATURE...: ");
            int temp = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("click C for Celcius (or) F for Farhenheit conversion...:");
            char input =Char.Parse( Console.ReadLine());
            if(input=='F'||input=='f')
            {
                Console.WriteLine(CelsiusToF(temp));
            }
            else
            {
                Console.WriteLine(FahrenheitToC(temp));
            }
        }
        public double CelsiusToF(int temp)
        {
            return (temp * (9.0 / 5.0)) + 32;
        }
        public double FahrenheitToC(int temp)
        {
            return (temp - 32) * 5.0 / 9.0;
        }

    }
}
