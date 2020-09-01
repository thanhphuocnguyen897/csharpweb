using System;
using System.Collections.Generic;
using System.Text;

namespace MyListClass
{
    public class MyList<T>
    {
        private int Capacity { get; set; }
        private Object[] Items;
        public MyList()
        {
            Items = new Object[10];
        }
        private void EnsureCapacity()
        {
            int newSize = Items.Length * 2;
            Array.Copy(Items, Items, newSize);
        }
        public void Add(T data)
        {
            if(Capacity == Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
        }
        public T GetData(int idx)
        {
            if(idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);
            }
            return (T)Items[idx];
        }
        //class MyListTest
        //{
        //    public static void Main()
        //    {
        //        Random rand = new Random();
        //        MyList<int> listInterger = new MyList<int>();
        //        for(int i = 0; i < listInterger.Capacity; i++)
        //        {
        //            listInterger.Add(rand.Next(1, 50));
        //        }
        //        Console.WriteLine("Item 1: " + listInterger.GetData(1));
        //        Console.WriteLine("Item 4: " + listInterger.GetData(4));
        //        Console.WriteLine("Item 2: " + listInterger.GetData(2));
        //        listInterger.GetData(6);
        //    }
        //}
    }
}
