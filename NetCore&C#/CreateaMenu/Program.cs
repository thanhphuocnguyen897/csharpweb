using System;

namespace CreateaMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while(choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
            
                switch (choice)
                {
                        case 1:
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 6; j > i; j--)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine(" ");
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 6; i++) 
                            {
                                Console.WriteLine("* * * * * * ");
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 3; i++) 
                            {
                                Console.WriteLine("* * * * * * ");
                            }
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("No choice!");
                            break;
                    }        
            }
        }
    }
}
