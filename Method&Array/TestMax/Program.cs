using System;

namespace TestMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 5;
            int j = 2;
            int k = testMax(i, j);
            Console.WriteLine("the maximum of {0} and {1} is {2}", i, j, k);
        }
        public static int testMax(int a, int b)
        {
            int result = a > b ? a : b;
            return result;
        }
    }
}
