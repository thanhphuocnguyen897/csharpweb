using System;

namespace ReverseIntegerStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            MyStack stack = new MyStack(6);
            for(int i = 0; i<arr.Length; i++)
            {
                stack.Push(arr[i]);
            }
            Console.WriteLine("1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2. Reverse elements from stack : ");

            while (!stack.IsEmpty())
            {
                arr[count] = stack.Pop();
                Console.Write(arr[count] + " ");
                count++;                
            }

            Console.WriteLine("\n3. Size of stack after pop operations : " + stack.Size());
        }
    }
    public class MyStack
    {
        private int[] arr;
        private int size;
        private int index = 0;
        public MyStack(int size)
        {
            this.size = size;
            arr = new int[size];
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
        public void Push(int element)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full!");
            }
            arr[index] = element;
            index++;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is null!");
            }
            return arr[--index];
        }
    }
}
