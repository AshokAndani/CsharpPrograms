using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
namespace ConsoleApp1
{
    class StopWatch
    {
       

        public StopWatch()
        {

            Stopwatch s = new Stopwatch();
            s.Start();int sec = 0;
            while(true)
            {
                
                
                Console.Clear();
                
                String format = String.Format("{0:00}:{1:00}",sec/60%60,sec++%60);
                Console.Write("running : "+format);
                Thread.Sleep(990);
                //char ch = char.Parse(Console.ReadLine());
                //if(ch=='c')
                //{
                //    System.Environment.Exit(0);
                //}


            }
        }
    }
}
