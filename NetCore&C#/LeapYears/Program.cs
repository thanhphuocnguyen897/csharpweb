using System;

namespace LeapYears
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isLeap = false;
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        isLeap = true;
                    };
                }
                else
                {
                    isLeap = true;
                }
            }
            if (isLeap)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}
