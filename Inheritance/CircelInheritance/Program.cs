using System;

namespace CircelInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(32.86, "Brown");
            Console.WriteLine(circle);
            Cylinder cylinder = new Cylinder(18.65, 12.68, "Blue");
            Console.WriteLine(cylinder);
            Console.WriteLine(cylinder.Volume());
            Console.WriteLine(cylinder.GetArea());
        }
    }
}
