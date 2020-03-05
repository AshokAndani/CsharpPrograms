using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GamblingSimulator
    {
        public GamblingSimulator()
        {
            Simulation();
        }
        public void Simulation()
        {
            Utility.Print("enter the goal..:  ");
            int goal = Utility.ReadInt();
            Utility.Print("enter the total amount you have: ");
            int total = Utility.ReadInt();
            int stake = 1;
            do
            {
                Utility.Print("enter the stake amount: ");
                stake = Utility.ReadInt();
                Random r = new Random();
                double random = r.Next(0,2);
                if(random==1)
                {
                    total += stake;
                    Utility.Println("you won..\n your total amount is : "+total);
                }
                else
                {
                    total -= stake;
                    Utility.Println("you lose..\n your total amount is : " +total);
                }
                
            } while (total < goal && total>0);
            if (total == goal)
                Utility.Println("you have reached the goal...");
            else if (total <=0)
                Utility.Println("you dont have stake to continue..");
            
        }
    }
}
