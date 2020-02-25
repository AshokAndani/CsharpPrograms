using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MonthlyPayment
    {
        public MonthlyPayment()
        {
            Utility.Print("enter the Principal amount : ");
            int p = Utility.ReadInt();
            Utility.Print("enter no. of Years for PayOff : ");
            int y = Utility.ReadInt();
            Utility.Print("enter the interest rate in Percentage : ");
            int r = Utility.ReadInt();
            Console.WriteLine(Payment(p,y,r));
        }
        public int Payment(int p,int y,int r)
        {
            double R = r / (12 * 100);
            int n = 12 * y;
            return (int)((p*R)/(1-Math.Pow((1+R),-n)));

        }
    }
}
