using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class QueueToStack
    {
	public static void DriverMethod()
		{
			QueueToStack q = new QueueToStack();
			Console.Write("Enter month: ");
			int m = int.Parse(Console.ReadLine());
			Console.Write("Enter year: ");
			int y = int.Parse(Console.ReadLine());
			Stack<Object> st = q.QueToStack(m,y);
			q.DisplayQueCalender(st);

			
			
		}
    }
}
