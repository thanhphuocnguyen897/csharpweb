using System;
using System.Collections.Generic;

namespace StackLinkedListDemo
{
    class GenericStackClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Stack of integers");
            StackOfIntegers();
            Console.WriteLine("\n2. Stack of Strings");
            StackOfStrings();
        }
        private static void StackOfIntegers()
        {
            MyGenericStack<Int32> stack = new MyGenericStack<Int32>();
            stack.Push(10);
            stack.Push(4);
            stack.Push(7);
            stack.Push(3);
            stack.Push(15);
            Console.WriteLine("2.1. Size of stack after push operations: " + stack.Size());
            Console.WriteLine("2.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n3.3 Size of stack after pop operations : " + stack.Size());
        }
        private static void StackOfStrings()
        {
            MyGenericStack<string> stack = new MyGenericStack<string>();
            stack.Push("Five");
            stack.Push("Four");
            stack.Push("Three");
            stack.Push("Two");
            stack.Push("One");
            Console.WriteLine("1.1 Size of stack after push operations: " + stack.Size());
            Console.WriteLine("1.2. Pop elements from stack..");
            while (!stack.IsEmpty())
            {
                stack.Pop();
            }
            Console.WriteLine("\n1.3. Size of stack after pop operations : " + stack.Size());
        }
    }
    public class MyGenericStack<T>
    {
        private LinkedList<T> stack;
        public MyGenericStack()
        {
            stack = new LinkedList<T>();
        }
        public int Size()
        {
            return stack.Count;
        }
        public bool IsEmpty()
        {
            if(stack.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Push(T element)
        {
            stack.AddFirst(element);
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                throw new Exception();
            }
            stack.RemoveFirst();
        }
    }
}
