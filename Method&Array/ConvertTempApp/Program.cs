using System;

namespace ConvertTempApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            double cel;
            double fah;
            int choice;
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1, Fahrenheit to Celsius.");
                Console.WriteLine("2, Celsius to Fahrenheit.");
                Console.WriteLine("3, Exit.");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter fahrenheit: ");
                        fah = Double.Parse(Console.ReadLine());
                        Console.WriteLine("{0} F to C is: {1}", fah, FtoC(fah));
                        //Console.Read();
                        break;
                    case 2:
                        Console.Write("Enter celsius: ");
                        cel = Double.Parse(Console.ReadLine());
                        Console.WriteLine("{0} C to F is: {1}", cel, CtoF(cel));
                        //Console.Read();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!!");
                        //Console.Read();
                        break;
                }
            } while (choice != 3);
            
        }
        public static double CtoF(double cel)
        {
            double fah = (9.0 / 5) * cel + 32;
            return fah;
        }
        public static double FtoC(double fah)
        {
            double cel = (5.0 / 9) * (fah - 32);
            return cel;
        }
    }
}
