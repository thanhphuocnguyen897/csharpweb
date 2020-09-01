using System;
using System.Collections.Generic;

namespace MyListClass
{
    public class MyListTest
    {
        public static void Main()
        {
            Random rand = new Random();
            MyList<int> listInteger = new MyList<int>();
            listInteger.Add(10);
            listInteger.Add(15);
            listInteger.Add(20);
            listInteger.Add(30);
            listInteger.Add(50);
            Console.WriteLine("Item 1: " + listInteger.GetData(1));
            Console.WriteLine("Item 4: " + listInteger.GetData(4));
            Console.WriteLine("Item 2: " + listInteger.GetData(2));
            //listInteger.GetData(6);
            //Console.WriteLine("Item -1: " + listInteger.GetData(-1));
        }
    }
}
