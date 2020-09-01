using System;
using System.Collections;
using System.Collections.Generic;

namespace GenerticListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> listNumber = new GenericList<int>();
            for(int x = 0; x < 10; x++)
            {
                listNumber.Add(x);
            }
            foreach(int i in listNumber)
            {
                Console.Write(i + " ");
            }
            foreach(int i in listNumber)
            {
                if(listNumber.Equal(3, i))
                {
                    Console.WriteLine("Have a element equal to input!.");
                }          
            }
        }
    }
    public class GenericList<T>
    {
        private class Node
        {
            private Node next;
            private T data;
            public Node(T t)
            {
                Next = null;
                Data = t;
            }

            public T Data { get => data; set => data = value; }
            public Node Next { get => next; set => next = value; }
        }
        private Node head;
        public GenericList()
        {
            head = null;
        }
        public void Add(T t)
        {
            Node n = new Node(t);
            
            n.Next = head;
            head = n;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public bool Equal(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else return false;
        }
    }
}
