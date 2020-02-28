using System;
using System.Text;

namespace DataStructures.Queue
{
    class CashCounter
    {
        public CashCounter()
        {
            Count();
        }
        public void Count()
        {
            Console.WriteLine("Enter the people in the Que");
            int num = Convert.ToInt32(Console.ReadLine());
            Queue<string> q = new Queue<string>(num);
            int amount = 10000;
            while (q.Size()<num)
            {
                Console.Write("enter the name of the Customer: ");
                q.Enqueue(Console.ReadLine());
            }
            
            Console.WriteLine("Current Balance available is "+amount);
           while(!q.IsEmpty())
            {
                Console.WriteLine(q.Dequeue()+ " Enter 'W' to Withdraw money or \n" +
                    "Enter 'D' to Deposit money");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Enter the  amount : ");
                int entered = Convert.ToInt32(Console.ReadLine());
                if(ch=='D' || ch=='d')
                {
                    amount += entered;
                    Console.WriteLine("Succesfully Deposited the amount");
                }
                else if(ch=='W' || ch=='w')
                {
                    if (entered > amount)
                        Console.WriteLine("amount exceeds the Bank Balance....!  ");
                    else
                    {
                        Console.WriteLine("Succesfully Withrawn the amount");
                        amount -= entered;
                    }
                }
                else Console.WriteLine("invalid Entry");
                Console.WriteLine("Available Bank Balance is: "+amount);
            }

            Console.WriteLine("End Of Que............");
           
            
        }

    }

}
