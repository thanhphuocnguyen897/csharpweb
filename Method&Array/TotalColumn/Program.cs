using System;

namespace TotalColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 6];
            Random rand = new Random();
            int column;
            int Height = array.GetLength(0);
            Console.WriteLine(Height);
            int Wigth = array.GetLength(1);
            Console.WriteLine(Wigth);
            Console.Write("Which column do you want to sum? ");
            column = Int32.Parse(Console.ReadLine());
            for (int row = 0; row < Height; row++)
            {
                for (int cols = 0; cols < Wigth; cols++)
                {
                    array[row, cols] = rand.Next(1, 100);
                    Console.Write(array[row, cols] + " ");
                }
                Console.WriteLine("\n");
            }
            int total = 0;
            for (int row = 0; row < Height; row++)
            {
                for (int cols = 0; cols < Wigth; cols++)
                {
                    if(cols == column - 1)
                    {
                        total += array[row, column - 1];
                    }
                }
            }
            Console.WriteLine("Total of column {0} is: {1}", column, total);
        }
    }
}
