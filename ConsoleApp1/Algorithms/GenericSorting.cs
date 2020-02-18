using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    class student : IComparable<student>
    {
        public string name;
        public int id;
        public int usn;
        
        public int CompareTo(student another)
        {
            if (this.id == another.id)
                return 0;
            if (this.id < another.id)
                return -1;
            else return 1;

        }
        
    }
    



}
