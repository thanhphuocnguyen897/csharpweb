using System;

namespace LinkedListDemo
{
    class Program
    {
        public static void Main()
        {
            Console.Title = "Custom Linked List";

            var list = new MyLinkedList<string>();

            list.Add("Hello");
            list.Add("World");
            list.Add("from");
            list.Add("my");
            list.Add("Linked List");

            list.Traverse(s => Console.Write($"{s} "));

            list.Remove("my");
            Console.WriteLine();
            list.Traverse(s => Console.Write($"{s} "));

            var n = list.Insert("my", "from");
            list.Insert("super", n);
            Console.WriteLine();
            list.Traverse(s => Console.Write($"{s} "));

            Console.Read();
        }
    }
}
