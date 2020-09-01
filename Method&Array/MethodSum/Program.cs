using System;

namespace MethodSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum 1 - 10 is: " + Sum(1, 10));
            Console.WriteLine("Sum 20 - 37 is: " + Sum(20, 37));
            Console.WriteLine("Sum 35 - 49 is: " + Sum(35, 49));
        }
        public static int Sum(int i1, int i2)
        {
            int result = 0;
            for (int i = i1; i <= i2; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
