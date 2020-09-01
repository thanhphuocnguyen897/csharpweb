using System;

namespace MyLinkedList
{
        class MyLinkedListTest
        {
            public static void Main()
            {
                MyLinkedList list = new MyLinkedList(10);
                list.AddFirst(11);
                list.AddFirst(12);
                list.AddFirst(13);
                list.Add(9, 4);
                list.Add(15, 4);
                list.PrintList();
            }
        }
    }
