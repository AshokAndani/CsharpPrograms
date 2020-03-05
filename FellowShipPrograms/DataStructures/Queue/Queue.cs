using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue<T>
    {
        int capacity;
        T[] obj;
        int front=-1, rear = -1;
        public Queue(int capacity)
        {
            this.capacity = capacity;
            obj = new T[capacity];
        }
        public bool Enqueue(T data)
        {
            if(rear==capacity-1)
            {
                Console.WriteLine("Que is Full");
                return false;
            }
            if(rear==-1)
                front++;
            obj[++rear] = data;
            return true;
        }
        public T Dequeue()
        {
            if(front == -1)
            {
                Console.WriteLine("que is empty");
                return default(T);
            }
            T ob= obj[front++];
            if (front > rear)
                front = rear = -1;
            return ob;
        }
        public bool IsEmpty()
        {
            if (rear == -1)
                return true;
            else return false;
        }
        public  int Size()
        {
            if (rear==-1)
            {
                return 0;
            }
            return rear - front + 1;
        }
        public override string ToString()
        {
            String s = "";
            for(int i=front;i<=rear && front!=-1;i++)
            {
                s = s + obj[i]+" ";

            }
            return s;
        }
    }
}
