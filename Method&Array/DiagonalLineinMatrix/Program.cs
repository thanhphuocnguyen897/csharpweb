using System;

namespace DiagonalLineinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[,] matrix;
            Random rand = new Random();
            int total = 0;
            Console.Write("Enter size: ");
            size = Int32.Parse(Console.ReadLine());
            matrix = new int[size, size];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                    Console.Write(matrix[i, j] + " ");
                    if(i == j)
                    {
                        total += matrix[i, j];
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Total diagonal line: " + total);
        }
    }
}
