using System;
namespace DataStructures.Deque
{
    class Deque<T>
    {
        
            public class Node
        {
            public T data;
            public Node pre;
            public Node next;
            public Node(T data)
            {
                this.data = data;
            }
           
        }
        public Node head;
        public void AddFront(T data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return;
            }
            n.next = head;
            head.pre = n;
            head = n;
            return;
        }
        public void AddRear(T data)
        {

            Node n = new Node(data);
            if(head==null)
            {
                head = n;
                return;
            }
            Node t = head;
            while(t.next!=null)
            {
                t = t.next;
            }
            t.next = n;
            n.pre = t;
            return;
        }
        public T RemoveFront()
        {
            if(head==null)
            {
                Console.WriteLine("que is Empty");
                return default;
            }
            T data = head.data;
            head = head.next;
            return data;
        }
        public T RemoveRear()
        {
            if(head==null)
            {
                Console.WriteLine("Deque is Empty");
                return default;
            }
            Node t = head;
            while(t.next!=null)
            {
                t = t.next;
            }
            T data = t.data;
            t.pre.next = null;
            return data;
        }
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            else return false;
        }
        public int Size()
        {
            int count = 0;
            if (head == null)
                return count;
            Node t = head;
            while(t!=null)
            {
                t = t.next;
                count++;
            }
            return count;
        }
        public override string ToString()
        {
            string s = "";
            Node t = head;
            while(t!=null)
            {
                s = s + t.data+" ";
                t = t.next;
            }
            return s;
        }

    }
}
