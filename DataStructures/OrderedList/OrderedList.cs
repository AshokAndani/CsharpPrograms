using System;
using DataStructures.OrderedList;

namespace DataStructures.OrderedList
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
        public bool Remove(int data)
        {
            if (Head == null)
                throw new NullReferenceException("list is empty");
            if (Head.next == null)
            {   if (Head.data.Equals(data))
                {
                    Head = null;
                    return true;
                }
                return false;

            }
            Node t = Head, pre = null;
            while (t != null)
            {
                if (t.data.Equals(data))
                {
                    pre.next = t.next;
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
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
        public bool Search(int data)
        {
            Node t = Head;
            while(t!=null)
            {
                if (t.data == data)
                    return true;
                t = t.next;
            }
            return false;
        }
        public int peek(int ind)
        {
            if (Head == null)
                return 0;
            if (ind == 0)
                return Head.data;
            Node t = Head;
            while (ind > 0)
            {
                ind--;
                t = t.next;
            }
            if (ind == 0)
                return t.data;
            return 0;
        }
        public bool IsEmpty()
        {
            if (Head == null)
                return true;
            else
                return false;
        }
        public int size()
        {
            int count = 0;
            Node t = Head;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }
        public int pop()
        {
            if (Head == null)
                throw new NullReferenceException("List is Empty");
            Node t = Head, p = null;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            int data = t.data;
            p.next = null;
            return data;
        }

        public int pop(int ind)
        { int data;
            if(ind==0)
            {
               data=Head.data;
                Head = Head.next;
                return data;
            }
            Node t = Head, pre = null;
            while(ind>0 && t!=null)
            {
                ind--;
                pre = t;
                t = t.next;
            }

            if (ind == 0)
            {
                data = t.data;
                pre.next = t.next;
                return data;
            }
            else throw new NullReferenceException("Index is Not in Range");
        }
        //correct
        public int Index(int data)
        {
            int count = 0;
            Node t=Head;
            while(t!=null)
            {
                if(t.data==data)
                {
                    break;
                }
                count++;
                t = t.next;
            }
            return count;
        }
    }
}
