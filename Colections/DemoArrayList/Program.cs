using System;
using System.Collections;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding some number...");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(32);
            al.Add(9);
            Console.WriteLine("Capacity {0}.", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
            Console.WriteLine("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sort content: ");
            al.Sort();
            foreach(int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
