using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.DataStructures.OrderedList;

namespace ConsoleApp1.DataStructures.OrderedList
{
    class OrderedList
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
            public int CompareTo(Node another)
            {
                if (this.data == another.data)
                    return 0;
                if (this.data > another.data)
                    return 1;
                else
                    return -1;
            }
        }
        Node Head;
        public void add(int data)
        {
            Node n = new Node(data);
            if(Head==null)
            {
                Head = n;
                return;
            }
            Node t = Head, p = null;
            while(t!=null)
            {
                if(Head.next==null)
                {
                    if (Head.data > n.data)
                    {
                        n.next = Head;
                        Head = n;
                        return;
                    }
                    else
                    { Head.next = n;
                        return;
                        }

                }
               if(p!=null && p.data>n.data)
                {
                    n.next = p;
                    Head = n;
                    return;
                }
               if(t.next==null && n.data>t.data)
                {
                    t.next = n;
                    return;
                }
               if(p!=null && p.data<n.data && t.data>n.data)
                {
                    n.next = p.next;
                    p.next = n;
                    return;
                }
                p = t;
                t = t.next;

            }
            return;
        }
        
        public override String ToString()
        {
            if (Head == null)
                return null;
            Node t = Head;
            String s = "";
            while(t!=null)
            {
                s = s + t.data + " ";
                t = t.next;
            }
            return s;
        }
    }
}
