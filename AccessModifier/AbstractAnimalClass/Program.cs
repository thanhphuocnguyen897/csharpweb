using System;

namespace AbstractAnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("5kg", "20cm", "Em");
            cat.PrintInfo();
            Console.WriteLine("Hello World!");
        }
    }
}
