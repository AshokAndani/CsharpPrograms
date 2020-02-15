using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VendingMachine
    {
        public VendingMachine()
        {
            Console.WriteLine("enter the amount you want in RS:");
            int amount = Convert.ToInt32(Console.ReadLine());
            GiveChange(amount);
        }
        public void GiveChange(int amount)
        {
            int number = 0;
            int th=0, five=0, hundred=0, fifty=0, twenty=0, ten=0, fiv=0, two=0, one=0;

            while(amount>=1000)
            {
                th++;number++;
                amount -= 1000;
            }
            while(amount>=500)
            {
                five++; number++;
                amount -= 500;
            }
            while(amount>=100)
            {
                hundred++; number++;
                amount -= 100;
            }
            while(amount>=50)
            {
                fifty++; number++;
                amount -= 50;
            }
            while(amount>=20)
            {
                twenty++; number++;
                amount -= 20;
            }
            while (amount >= 10)
            {
                ten++; number++;
                amount -= 10;
            }
            while(amount>=5)
            {
                fiv++; number++;
                amount -= 5;
            }
            while(amount>=2)
            {
                two++; number++;
                amount -= 2;
            }
            while(amount>=1)
            {
                one++; number++;
                amount -= 1;
            }
            Console.WriteLine("number of changes are " + number);
            if(!(th==0))
            {
                Console.WriteLine(th + " Thousand  Notes");
            }
            if (!(five == 0))
            {
                Console.WriteLine(five+ " FiveHundred Notes");
            }
            if (!(hundred == 0))
            {
                Console.WriteLine(hundred + " Hundred rupee Notes");
            }
            if (!(fifty== 0))
            {
                Console.WriteLine(fifty + " Fifty rupee Notes");
            }
            if (!(twenty == 0))
            {
                Console.WriteLine(twenty+ " Twenty rupee Notes");
            }
            if (!(ten== 0))
            {
                Console.WriteLine(ten + " Ten rupee Notes");
            }
            if (!(fiv== 0))
            {
                Console.WriteLine(fiv+ " Five rupee coin");
            }
            if (!(two== 0))
            {
                Console.WriteLine(two + " Two rupee coin");
            }
            if (!(one == 0))
            {
                Console.WriteLine(one + " one rupee coins");
            }
        }


    }
}
