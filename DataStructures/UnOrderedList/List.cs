using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.UnOrderedList
{
   public class List<T>
    {
        public class Node
        {
            public T data;
            public Node next;
            public Node(T data)
            {
                this.data = data;
            }
        }
        private Node head;
        //correct
        public bool Append(T data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            return true;
        }
        //correct
        public T Pop()
        {
            if (head == null)
            {
                throw new NullReferenceException("List is Empty");
            }
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            T obj = t.data;
            p.next = null;
            return obj;
        }
        public T peek(int ind)
        {
            if (head == null)
            {
                return (T)default;
            }
            if (ind == 0)
                return head.data;
            Node t = head;
            while(ind>0 && t.next!=null)
            {
                ind--;
                t = t.next;
            }
            if (ind == 0)
                return t.data;
            return (T)default;
        }
        //correct
        public T peek()
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            T obj = t.data;
            return obj;
        }
        //correct
        public bool Search(T data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.next;
            }
            return false;
        }
        //correct
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            return false;
        }
        //correct
        public int Size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }
        //correct
        public bool Add(T data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        //correct
        public override string ToString()
        {
            if (head == null)
            {
                
                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data+" ";
                t = t.next;
            }
            return s;
        }
        //correct
        public int Index(T data)
        {
            int count = -1;
            if (head == null)
                return -1;
            Node t = head;
            while (t != null)
            {
                count++;
                if (t.data.Equals(data))
                    return count;
                t = t.next;

            }
            return -1;
        }
        public bool Insert(int ind, T data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head.next;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }
        //correct
        public bool Remove(T data)
        {
            if (head == null)
                throw new NullReferenceException("list is empty");
            if (head.next == null)
                head = null;
            Node t = head, pre = null;
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
        public T Pop(int ind)
        {
            T obj;
            if (ind == 0)
            {
                obj = head.data;
                head = head.next;
                return obj;
            }
            Node t = head, pre = null;
            while(ind>0 && t!=null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
             

            if (ind == 0)
            {
                pre.next = t.next;
                obj = t.data;
                return obj;
            }
            throw new NullReferenceException("index is not range");
            
            
        }
        public T[] ToArray()
        {
            int size=Size();
            T[] array = new T[size];
            for(int i=0;i<size;i++)
            {
                array[i] = peek(i);
            }
            return array;
        }
    }
}
