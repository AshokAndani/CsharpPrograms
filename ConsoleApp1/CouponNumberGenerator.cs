using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CouponNumberGenerator
    {
        public CouponNumberGenerator()
        {
            Console.WriteLine("enter the number of distinct Coupon number you Want: ");
            string[] coupons=Coupon(Utility.ReadInt());
            foreach (String value in coupons)
            {
                Console.WriteLine("the coupon number generated is : "+value);
            }

        }
        public string[] Coupon(int n)
        {
            string[] Array = new string[n];
            int i = 0;
            while(i<n)
            {
                String value = "";
                value = value + RandomValue.bigChar() + RandomValue.IntRange(500, 10000) + RandomValue.RandomString() +
                   RandomValue.IntRange(1000, 2000);
                foreach (string checking in Array)
                {
                    if((value.Equals(checking)))
                    {
                        i--;
                    }
                }
                Array[i++] = value;
            }
            
            return Array;
            
        }
  
    }
}
