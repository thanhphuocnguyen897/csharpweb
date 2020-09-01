using System;

namespace LinearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a.x + b = 0', Please enter constants: ");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x;
            if (a != 0)
            {
                x = -b / a;
                Console.Write("The Solution is: {0}!", x);
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("the solution is all x!");
                }
                else
                {
                    Console.WriteLine("None solution");
                }
            }
        }
    }
}
