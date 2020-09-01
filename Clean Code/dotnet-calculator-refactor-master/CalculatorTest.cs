using System;

namespace calculate_refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Calculate(3, 4, '+');
            Console.WriteLine(result);
        }
    }
}
