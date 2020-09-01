using System;

namespace Factory_Pattern_Practise
{
    class FactoryDemo
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            IAnimal a1 = factory.GetAnimal("cat");
            Console.WriteLine("Animal 1 sound: " + a1.MakeSound());
            IAnimal a2 = factory.GetAnimal("dog");
            Console.WriteLine("Animal 2 sound: " + a2.MakeSound());
        }
    }
    public interface IAnimal
    {
        string MakeSound();
    }
    public class Dog: IAnimal
    {
        public string MakeSound()
        {
            return "Woof";
        }
    }
    public class Cat: IAnimal
    {
        public string MakeSound()
        {
            return "Meow";
        }
    }
    public class AnimalFactory
    {
        public IAnimal GetAnimal(string animal)
        {
            switch (animal)
            {
                case "dog":
                    return new Dog();
                default:
                    return new Cat();
            }
        }
    }
}
