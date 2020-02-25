using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TwoDimensionalArray
    {
        public TwoDimensionalArray()
        {
            Console.Write("enter the row: ");
            int m = Utility.ReadInt();
            Console.Write("enter the row: ");
            int n = Utility.ReadInt();
            int[,] arr = new int[m, n];
            Console.Write("size is " + arr.Length);
            SetArray(arr);
            DisplayArray(arr);


        }
        public void DisplayArray(int[,]arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void SetArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("enter the value: ");
                    arr[i, j] = Utility.ReadInt();
                }
            }
        }
    }
}
