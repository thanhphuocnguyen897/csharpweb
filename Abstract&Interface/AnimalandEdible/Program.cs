using System;

namespace AnimalandEdible
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            Fruits[] fruits = new Fruits[2];
            fruits[0] = new Apple();
            fruits[1] = new Orange();
            foreach(Fruits fruits1 in fruits)
            {
                Console.WriteLine(fruits1.HowtoEat());
            }
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.Makesound());
                if(animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowtoEat());
                }
            }
            
        }
    }
}
