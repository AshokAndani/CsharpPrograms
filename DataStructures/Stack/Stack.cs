using System;

namespace DataStructures.Stack
{
	public class Stack<T>
	{
		int capacity;
		T[] obj;
		int top = -1;
		public Stack(int capacity)
        {
			this.capacity = capacity;
			obj = new T[capacity];
        }
		public bool Push(T data)
		{
			if(top==capacity-1)
            {
				Console.WriteLine("Stack overFlow");
				return false;
            }
			obj[++top] = data;
			return true;
		}
		public T Pop()
        {
			if(top==-1)
            {
                Console.WriteLine("Stack Underflow");
				return default(T);
            }
			return obj[top--];
        }
		public  T Peek()
        {
			if(top==-1)
            {
                Console.WriteLine("Stack is UnderFlow"	);
				return (T)default;
            }
			return obj[top];
        }
		public bool IsEmpty()
        {

			if (top == -1)
				return true;
			else return false;
        }
		public int Size()
        {
			return top + 1;
        }
		public override string ToString()
		{
			String s = "";
			for(int i=0;i<capacity;i++)
			{
				s = s + obj[i]+" ";
			}
			return s;
		}

	}
}
