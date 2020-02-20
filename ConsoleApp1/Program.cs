using System;
using ConsoleApp1.Algorithms;
using ConsoleApp1.DataStructures;
using ConsoleApp1.DataStructures.UnOrderedList;

namespace ConsoleApp1
{
    class Program //driver code
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to invoke the object...!");
            int number = Utility.ReadInt();
            switch (number)
            {
                // in order to invoke the object and process the results codes are written in constructor.
                case 0: new Test(); break;
                case 1:new LeapYear(); break;
                case 2:new Factorial(); break;
                case 3:new HarmonicNumber(); break;
                case 4: new UserInput();break;
                case 5:new FlipCoin(); break;
                case 6:new TwoDimensionalArray(); break;
                case 7:new PowerOf2(); break;
                case 8:new TripletsEqaulsToZero(); break;
                case 9: new DayOfWeek(); break;
                case 10:new Distance(); break;
                case 11:new Quadratic(); break;
                case 12:new WindChill(); break;
                case 13:new GamblingSimulator(); break;
                case 15:new CouponNumberGenerator(); break;
                case 16:new StopWatch(); break;
                case 17:new TicTacToe(); break;
                case 18:new VendingMachine(); break;
                case 19: new TemperatureConversion(); break;
                case 20:new MonthlyPayment(); break;
                case 21:new Sqrt(); break;
                case 22:new ToBinary(); break;
                


                // without creating the objects and only using a static driver method in to process the result
                // from here...
                case 23: new BinarySearchWord().DriverMethod(); break;
                case 24: Binary.Driver(); break;
                case 25: AnagramDetection.DriverMethod(); break;
                case 26: RangeOfPrimeNumbers.DriverMethod(); break;
                case 27: StringPermutationRecursion.DriverMethod("ABC"); break;
                case 28: RegexPatternMessage.DriverMethod(); break;
                case 29: MagicNumberGuess.DriverMethod(); break;
                case 30: MergeSorting.DriverMethod(); break;
                case 31: StringPermutationIterative.DriverPermute("ABC"); break;
                case 32: ComparePermutations.DriverMethod(); break;
                case 33: ReadFromFile.DriverMethod(); break;
                //data Structures
                //case 33:new List();
                
                
                
                
                
                
                default:Console.WriteLine("invalid Entry"); break;
                
            }

        }
        
    }
}
