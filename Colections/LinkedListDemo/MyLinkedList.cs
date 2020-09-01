using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    class MyLinkedList<T> where T : IComparable
    {
        public Node<T> Head { get; set; } = new Node<T>();

        public Node<T> Find(T data)
        {
            var currentNode = Head;
            while (currentNode.Next != null && currentNode.Data?.CompareTo(data) != 0)
            {
                currentNode = currentNode.Next;
            }
            if (currentNode != Head)
            {
                return currentNode;
            }
            return null;
        }

        public Node<T> FindPrevious(T data)
        {
            var currentNode = Head;
            while (currentNode.Next != null && currentNode.Data?.CompareTo(data) != 0)
            {
                currentNode = currentNode.Next;
            }
            if (currentNode != Head)
            {
                return currentNode;
            }
            return null;
        }

        public Node<T> Insert(T data, T afterValue)
        {
            var newNode = new Node<T>(data);
            var currentNode = Find(afterValue);
            if (currentNode != null)
            {
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
                return newNode;
            }
            return null;
        }

        public Node<T> Insert(T data, Node<T> afterNode)
        {
            var newNode = new Node<T>(data);
            var currentNode = afterNode.Next;
            afterNode.Next = newNode;
            return newNode;
        }

        public Node<T> Add(T data)
        {
            var currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            var newNode = new Node<T>(data);
            currentNode.Next = newNode;
            return newNode;
        }

        public void Remove(T data)
        {
            var previousNode = FindPrevious(data);
            if (previousNode != null)
            {
                previousNode.Next = previousNode.Next.Next;
            }
        }
        public void Traverse(Action<T> action)
        {
            var currentNode = Head;
            while (currentNode.Next != null)
            {
                action?.Invoke(currentNode.Next.Data);
                currentNode = currentNode.Next;
            }
        }
    }
}
