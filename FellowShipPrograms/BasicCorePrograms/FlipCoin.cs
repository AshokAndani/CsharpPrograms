using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FlipCoin
    {
        public FlipCoin()
        {
            flipCoin();
            
        }
        public void flipCoin()
        {
            Console.WriteLine("enter the number of times the coin flipped ");
            int number = Utility.ReadInt();
            if (number <= 0)
                Console.WriteLine("the coin is not flipped try again..!");
            else
            { double t = number;
                double head = 0, tail = 0;
                while (number > 0)
                {
                    Random random = new Random();
                    float num = (float)random.NextDouble();
                    //Console.WriteLine(num);
                    if (num > 0.5)
                    { head++; }
                    else
                    {        tail++;
                }
                    number--;


                }
                double h = (head / t) * 100.0;
                double ta = (tail / t) * 100.0;

                Console.WriteLine("percentage of heads vs tail is "+h+"% and "+ta+"%");
            }
        }
    }
}
