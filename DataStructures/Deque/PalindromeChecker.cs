using System;
namespace DataStructures.Deque
{
    class PalindromeChecker
    {
        public static void DriverMethod()
        {
            Console.WriteLine("enter the String  to check for Palindrome:");
            string st = Console.ReadLine();
            isPalindrome(st);
        }
        public static bool isPalindrome(string st)
        {
            //adding elements to que
            Deque<char> q = new Deque<char>();
            for (int i = 0; i < st.Length; i++)
                q.AddRear(st[i]);
            
            
            while(!q.IsEmpty())
            {
                //at last there there is only 1 element will be present 
                //so breaking at that point
                if (q.Size() == 1)
                    break;
                if(!(q.RemoveFront().Equals(q.RemoveRear())))
                {
                    Console.WriteLine("given String is Not Palindrome");
                    return false;
                }
            }
            Console.WriteLine("Given String is Palindrome");
            return true;
        }
    }
}
  