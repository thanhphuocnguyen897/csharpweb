using System;

namespace _20FirstPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int N = 2;
            while(count < number)
            {
                bool check = true;
                for(int i = 2; i<N; i++)
                {
                    if (N % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine(N);
                    count++;
                }
                N++;
            }
        }
    }
}
