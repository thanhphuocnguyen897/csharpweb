using System;

namespace ReverseStringStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string mWord;
            
            mWord = Console.ReadLine();
            string[] mword = mWord.Split(" ");
            Console.WriteLine(mWord[1]);
            MyStack stack = new MyStack(mWord.Length);
            for (int i = 0; i < mword.Length; i++)
            {
                stack.Push(mword[i]);
            }
            Console.WriteLine("1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2. Reverse elements from stack : ");

            while (!stack.IsEmpty())
            {
                mword[count] = stack.Pop();
                Console.Write(mword[count] + " ");
                count++;
            }

            Console.WriteLine("\n3. Size of stack after pop operations : " + stack.Size());

        }
    }
    public class MyStack
    {
        private string[] arr;
        private int size;
        private int index = 0;
        public MyStack(int size)
        {
            this.size = size;
            arr = new string[size];
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
        public void Push(string element)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full!");
            }
            arr[index] = element;
            index++;
        }
        public string Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is null!");
            }
            return arr[--index];
        }
    }
}
