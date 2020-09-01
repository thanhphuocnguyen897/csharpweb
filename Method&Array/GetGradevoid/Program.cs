using System;

namespace GetGradevoid
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("The grade is: ");
            PrintGrade(78.5);

            PrintGrade(-10.5);

            System.Console.WriteLine("The grade is: ");
            PrintGrade(58.5);

            Console.WriteLine("The grade is " + GetGrade(90.5));
            Console.WriteLine("\nThe grade is " + GetGrade(65.8));

            System.Console.Read();
        }
        public static void PrintGrade(double score)
        {
            if (score >= 90.0)
            {
                System.Console.WriteLine("A");
            }
            else if (score < 0 || score > 100.0)
            {
                Console.WriteLine("Invalid score!");
                return;
            }
            else if (score >= 80.0)
            {
                System.Console.WriteLine("B");
            }
            else if (score >= 70.0)
            {
                System.Console.WriteLine("C");
            }
            else if (score >= 60.0)
            {
                System.Console.WriteLine("D");
            }
            else
            {
                System.Console.WriteLine("F");
            }
        }
        public static char GetGrade(double score)
        {
            if (score >= 90.0)
            {
                return 'A';
            }
            else if (score >= 80.0)
            {
                return 'B';
            }
            else if(score >= 70.0)
            {
                return 'C';
            }
            else if(score >= 60.0)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}
