using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TripletsEqaulsToZero
    {
        public TripletsEqaulsToZero()
        {
            Console.WriteLine("enter the Size of array");
            int[] arr = new int[Utility.ReadInt()];

            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write("enter the value: ");
                arr[i] = Utility.ReadInt();
            }
            Triplets(arr);
        }
        public void Triplets(int[] arr)
        {
            int count = 0, i, j, k;
            for(i=0;i<arr.Length-2;i++)
            {
                for(j=i+1;j<arr.Length-1;j++)
                {
                    for(k=j+1;k<arr.Length;k++)
                    {
                        if(arr[i]+arr[j]+arr[k]==0)
                        {
                            count++;
                            Console.Write(arr[i] + " " + arr[j] + " " + arr[k]);
                            Console.WriteLine();
                        }
                    }
                }
                
            }
            Console.WriteLine("Total number of Distinct triplets are : " + count);

        }
    }
}
