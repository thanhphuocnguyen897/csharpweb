using System;

namespace Array2DSample
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int total = 0;
            Console.WriteLine("Enter {0} rows and {1} columns:", matrix.GetLength(0), matrix.GetLength(1));
            Random rand = new Random();
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rand.Next(1, 10); //nhập vào mảng bằng random
                    Console.Write(matrix[row, col] +"  "); // in ra mảng
                    total += matrix[row, col]; ; //tổng các phần tử trong mảng
                }
                Console.WriteLine("\n");
            }
            //BiggestRow(matrix);
            //TotalColumn(matrix);
            MixMatrix(matrix);
            ////Console.Write("total is: "+ total);
        }
        public static void EnterMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++) 
            {
                for (int col = 0; col < matrix.GetLength(1); col++) 
                {
                    Console.Write("Matrix[{0},{1}]", row, col);
                    matrix[row, col] = Int32.Parse(Console.ReadLine()); //nhập vào mảng bằng tay
                }
            }
        }
        public static void TotalColumn(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int total = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    total += matrix[row, col];
                }
                Console.WriteLine("Sum of column " + " is " + total);
            }
        }
        public static void BiggestRow(int[,] matrix)
        {
            int maxRow = 0;
            int indexOfMaxrow = 0;
            //Lấy tổng của hàng đầu tiên gán cho maxRow
            for (int row = 0; row < matrix.GetLength(0); row++) 
            {
                maxRow += matrix[row, 0];
            }
            for (int row = 1; row < matrix.GetLength(0); row++) 
            {
                int totalOfThisRow = 0;
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    totalOfThisRow += matrix[row, col];
                    if(totalOfThisRow > maxRow)
                    {
                        maxRow = totalOfThisRow;
                        indexOfMaxrow = row;
                    }
                }
            }
            Console.WriteLine("Max Row is: " + maxRow);
            Console.WriteLine("index: " + indexOfMaxrow);
        }
        public static void MixMatrix(int[,] matrix)
        {
            Random rand = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int row1 = (int)(rand.Next(0, matrix.GetLength(0)));
                    int col1 = (int)(rand.Next(0, matrix.GetLength(1)));
                    //swap matrix
                    int temp = matrix[row, col];
                    matrix[row, col] = matrix[row1, col1];
                    matrix[row1, col1] = temp;
                    Console.Write(matrix[row, col] + "  ");
                }
                Console.WriteLine("\n");
            }                
        }
    }
}
