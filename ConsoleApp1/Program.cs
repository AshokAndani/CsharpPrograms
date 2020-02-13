using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number from 1 to 10...!");
            int number = Utility.ReadInt();
            switch (number)
            {
                case 1:
                    new LeapYear();
                    break;
                case 2:
                    new Factorial();
                    break;
                case 3:
                    new HarmonicNumber();
                    break;
                default:
                    Console.WriteLine("invalid Entry");
                    break;
            }

        }
        
    }
}
