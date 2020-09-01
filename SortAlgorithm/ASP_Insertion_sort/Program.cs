using System;

namespace ASP_Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort(arr);
            PrintArray(arr);
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1; i < n; ++i)
            {
                int key = arr[i];
                Console.WriteLine("Key first " + key + " with position " + i);
                int j = i - 1;
                /*Move element of array[0..i-1],
                 * that are greater than key,
                 * to one position ahead of their
                 * current position*/
                while (j >= 0 && arr[j] > key)
                {
                    Console.WriteLine("{0} > {1}?: {2} ", arr[j], key, (arr[j] > key));
                    Console.WriteLine("a{0} with a{1}, Swap {2} and {3}", j, (j+1), arr[j+1], arr[j]);
                    arr[j + 1] = arr[j];
                    Console.WriteLine("arr[{0}] is arr[{1}] now {2}", j, (j+1), arr[j]);
                    j = j - 1;
                    //Console.WriteLine("Position j is " + j);
                }
                arr[j + 1] = key;
                Console.WriteLine("key is " + key + " with position is " + (j+1));
                Console.WriteLine();
            }
        }
        static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
