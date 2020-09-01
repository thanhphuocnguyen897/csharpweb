using System;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int choice = -1;
            while (choice != 4)
            {
                Console.WriteLine("Please enter your choice!");
                Console.WriteLine("1. Print the rectangle: ");
                Console.WriteLine("2. Print square triangle: ");
                Console.WriteLine("3. Print isosceles triangle: ");
                Console.WriteLine("4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your rectangle: ");
                        for (int i = 0; i <= 3; i++)
                        {
                            for (j = 0; j <= 7; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Your square trianle: ");
                        for (int i = 0; i <= 5; i++)
                        {
                            for (j = 0; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                        for (int i = 0; i <= 5; i++)
                        {
                            for (j = 6; j > i; j--)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                        for (int i = 0; i <= 5; i++)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (j = 5; j >= i; j--)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        for (int i = 0; i <= 5; i++)
                        {
                            for (j = 6; j >= i; j--)
                            {
                                Console.Write("  ");
                            }
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Your isoceles triangle: ");
                        for (int i = 0; i <= 5; i++)
                        {
                            for (j = 6; j >= i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice");
                        break;
                }
            }
        }
    }
}
