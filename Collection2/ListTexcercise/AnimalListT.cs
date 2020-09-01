using System;
using System.Collections.Generic;

namespace ListTexcercise
{
    class AnimalListT
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("lion");
            animals.Add("cat");
            animals.Add("dog");
            animals.Add("elephant");
            foreach(string animal in animals)
            {
                Console.Write(animal + " ");
            }
            animals.Remove("dog");
            animals.Sort();
            Console.WriteLine();
            foreach (string animal in animals)
            {
                Console.Write(animal + " ");
            }
        }
        //public static PrintValue()
        //{
        //    foreach(string )
        //}
    }
}
