
using System;
using System.Text;
using DataStructures.Queue;
using DataStructures.UnOrderedList;

namespace DataStructures
{
    class WeeksInQue
    {
        static Calender calender = new Calender();
        public static void DriverMethod()
        {
            WeeksInQue w = new WeeksInQue();
            Console.WriteLine("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            
            int[,] array = calender.calender(month, year);
            w.CalenderToQue(month, year);
            w.DisplayQueCalender(w.CalenderToQue(month,year));
        }
 public Queue<Object> CalenderToQue(int m,int y)
        {
            Queue<Object> res = new Queue<object>(7);
            string[] week_name = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", 
                "Friday", "Saturday" };

            Week[] obj = new Week[7];
            for(int i=0;i<obj.Length;i++)
            {
                obj[i] = new Week(week_name[i]);
            }