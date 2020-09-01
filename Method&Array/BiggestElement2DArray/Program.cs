using System;

namespace BiggestElement2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,6];
            Random rand = new Random();
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 50);
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
            int max = matrix[0, 0];
            int indexx = 0;
            int indexy = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        indexy = i;
                        indexx = j;
                    }
                }
            }
            Console.WriteLine("The biggest is matrix[{0},{1}] = {2}", indexy, indexx, max);
        }
    }
}
