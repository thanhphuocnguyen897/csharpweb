using System;
using System.Collections;

namespace ArrayListDemo
{
    class SampleArrayList
    {
        static void Main(string[] args)
        {
            //Not recommend to use!
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            Console.WriteLine("myAL");
            Console.WriteLine("   Count:    {0}", myAL.Count);
            Console.WriteLine("   Capacity: {0}", myAL.Capacity);
            Console.Write("   Values: ");
            PrintValues(myAL);
        }
        public static void PrintValues(IEnumerable mylist)
        {
            foreach(Object obj in mylist)
            {
                Console.Write("  {0}", obj);
            }
            Console.WriteLine();
        }
    }
}
