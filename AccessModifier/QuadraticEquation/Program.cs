using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter a, b, c: ");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());
            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            if(equation.GetDiscriminant() > 0)
            {
                Console.WriteLine("Root 1: " + equation.GetRoot1());
                Console.WriteLine("Root 2: " + equation.GetRoot2());
            }
            else if(equation.GetDiscriminant() == 0)
            {
                Console.WriteLine("1 root: " + equation.GetRoot1());
            }
            else
            {
                Console.WriteLine("Equation has no root.");
            }
        }
    }
}
