using System;
using System.Collections.Specialized;

namespace DecimaltoBinaryStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Decimal toBinary;
            Console.WriteLine("Enter decimal: ");
            toBinary = Decimal.Parse(Console.ReadLine());
            MyStack stack = new MyStack(10);
            while (toBinary > 1)
            {
                stack.Push(toBinary % 2);
                toBinary = toBinary / 2;
            }
            Console.WriteLine("2. Reverse elements from stack : ");

            while (!stack.IsEmpty())
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
    public class MyStack
    {
        private decimal[] arr;
        private int size;
        private int index = 0;
        public MyStack(int size)
        {
            this.size = size;
            arr = new decimal[size];
        }
        public bool IsEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if (index == size)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            return index;
        }
        public void Push(decimal element)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full!");
            }
            arr[index] = element;
            index++;
        }
        public decimal Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is null!");
            }
            return arr[--index];
        }
    }
}
