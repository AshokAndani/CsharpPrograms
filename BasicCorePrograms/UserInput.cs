using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UserInput
    { 
        public UserInput()
        {
            Utility.print("enter your name: ");
            String name = Utility.ReadString();
            if ((name.Length >= 3))
                Console.WriteLine("hello " + name + ", how are you...!");
            else Console.WriteLine("invalid name, should have atleast 3 charectors....!");
        }

    }
}
