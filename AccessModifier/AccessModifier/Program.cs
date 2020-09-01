using System;

namespace AccessModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Console.WriteLine(circle.GetRadius());
            Console.WriteLine(circle.GetColor());
        }
    }
}
