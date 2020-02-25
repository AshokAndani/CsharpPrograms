using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PrimeFactors
    {
        public PrimeFactors()
        {
            Console.WriteLine("enter the number for its PrimeFactors..");
            Factors(Utility.ReadInt());

        }
        public void Factors(int n)
        {
            for(int i=2;i*i<=n;i++)
            {
                while(n%i==0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
                
            }
            if (n > 1)
                Console.Write(n);
        }
    }
}
