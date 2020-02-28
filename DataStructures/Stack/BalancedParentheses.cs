using System;
namespace DataStructures.Stack
{
    class BalancedParentheses
    {
        public static void DriverMethod()
        {
            Console.Write("enter arithmetic Equation: ");
            string ar = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(Balanced(ar));
        }
        public static bool Balanced(string ar)
        { 
            Stack<Char> stack = new Stack<Char>(ar.Length);
            for(int i=0;i<ar.Length;i++)
            {
                char ch = ar[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.IsEmpty())
                        return false;
                    if (ch == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();

        }
    }
}
