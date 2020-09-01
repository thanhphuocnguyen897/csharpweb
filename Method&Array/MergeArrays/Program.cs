using System;

namespace MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array12 = new int[20];
            Random rand = new Random();
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(1, 20);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next(10, 30);
                Console.Write(array2[i] + " ");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array12[i] = array1[i];
            }
            for(int j = 0; j < array2.Length; j++)
            {
                array12[j + array1.Length] = array2[j];
            }
            Console.WriteLine("\n");
            for(int j = 0; j < array12.Length; j++)
            {
                Console.Write(array12[j] + " ");
            }
        }
    }
}
