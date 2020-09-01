using System;

namespace PrimeNumberLower100
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("List of prime number lower 100: ");
            for(int i = 2; i <= 100; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if(count == 2)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
        }
    }
}
