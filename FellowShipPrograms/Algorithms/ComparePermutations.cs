using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    class ComparePermutations
    {
        public static void DriverMethod()
        {
            Console.Write("enter the String: ");
            String st = Console.ReadLine();
            List<String> lst1 = StringPermutationIterative.DriverPermute(st);
            List<String> lst2 = StringPermutationRecursion.DriverMethod(st);
            Console.WriteLine("the Permutations from the Iterative are:");
            foreach (string s in lst1)
                Console.WriteLine(s);

            Console.WriteLine("the Permutations form Recursion are: ");
            foreach (string x in lst2)
                Console.WriteLine(x);
            String[] lst11 = lst1.ToArray();
            String[] lst22 = lst2.ToArray();
            for(int i=0;i<lst11.Length;i++)
            {
                bool flag = false;
                for(int j=0;j<lst22.Length;j++)
                {
                    if (lst11[i].Equals(lst22[j]))
                        flag = true;
                }
                if(flag==false)
                {
                    Console.WriteLine("Both are not same...!");
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine("Both the methods got the same Permutations");
            

        }
        

    }
}
