using System;

namespace CalculateInterestRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1.0;
            double rate = 1.0;
            int month = 1;
            double interest = 0;
            Console.WriteLine("Enter investment amount: ");
            amount = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest rate: ");
            rate = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < month; i++)
            {
                interest = amount * (rate / 100) / 12 * 3;
            }
            Console.WriteLine("Interest is: " + interest);
        }
    }
}
