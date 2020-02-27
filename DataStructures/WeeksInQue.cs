using System;
using System.Text;
using DataStructures.Queue;
using DataStructures.UnOrderedList;

namespace DataStructures
{
    class WeeksInQue
    {

        public static void DriverMethod()
        {
            WeeksInQue w = new WeeksInQue();
            Console.WriteLine("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            int year = int.Parse(Console.ReadLine());
            Calender calender = new Calender();
            int[,] array = calender.calender(month, year);
        }
        public Queue<List<Object>> CalenderArrayToQue(int m,int y)
        {
            string[] week_name = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", 
                "Friday", "Saturday" };

            Week[] obj = new Week[7];
            for(int i=0;i<obj.Length;i++)
            {
                obj[i] = new Week(week_name[i]);
            }
            

            Calender c = new Calender();
            int d=c.DayOfWeek(1,m,y);
            int LastDate = c.DaysInMonth(m);
            int objects = d;
            for (int i=1;i<=LastDate;i++)
            {
                if (i == 1) obj[objects++]= i;

            }

    }
    }
    public class Week
    {
        public string week;
        List<int> list = new List<int>();        
        public Week(string week)
        {
            this.week = week;
            
        }
    }
}
