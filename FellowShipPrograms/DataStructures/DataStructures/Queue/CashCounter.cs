using System;
using System.Collections.Generic;
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
            Console.WriteLine("Enter the peoples in the Que");
            int num = Convert.ToInt32(Console.ReadLine());
            Queue<string> q = new Queue<string>(num);
           while(q.Size()<num)
            {
                q.Enqueue(Console.ReadLine());
            }
            Console.WriteLine(q);
            Console.WriteLine(q.Size());
            
        }

    }

}
