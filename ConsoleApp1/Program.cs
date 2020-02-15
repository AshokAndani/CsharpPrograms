using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to invoke the object...!");
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
                case 4:
                    new UserInput();
                    break;
                case 5:
                    new FlipCoin();
                    break;
                case 6:
                    new TwoDimensionalArray();
                    break;
                case 7:
                    new PrimeFactors();
                    break;
                case 8:
                    new PowerOf2();
                    break;
                case 9:
                    new TripletsEqaulsToZero();
                    break;
                case 10:
                    new Distance();
                    break;
                case 11:
                    new Quadratic();
                    break;
                case 12:
                    new WindChill();
                    break;
                case 13:
                    new GamblingSimulator();
                    break;
                case 14:
                    new Test();
                    break;
                case 15:
                    new CouponNumberGenerator();
                    break;
                case 16:
                    new StopWatch();
                    break;
                case 17:
                    new TicTacToe();
                    break;
                default:
                    Console.WriteLine("invalid Entry");
                    break;
            }

        }
        
    }
}
