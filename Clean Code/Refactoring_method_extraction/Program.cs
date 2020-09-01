using System;

namespace Refactoring_method_extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = CylinderDemo.GetVolume(2, 4);
            Console.WriteLine(result);
        }
    }
}
