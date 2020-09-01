using System;

namespace ASP_Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            PrintArray(arr);
            SelectionSort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);
        }
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n; i++)
            {
                // Find the minimum element in unsorted array
                int min_indx = i;
                for (int j = i + 1; j < n; j++) 
                {
                    if (arr[j] < arr[min_indx])
                        min_indx = j;
                    Console.WriteLine("min index: " + min_indx);
                }
                // Swap the found minimum element with the first element
                Console.WriteLine("arr min : {0} and arr i: {1} before swap", arr[min_indx], arr[i]);
                int temp = arr[min_indx];
                arr[min_indx] = arr[i];
                arr[i] = temp;
                Console.WriteLine("arr min : {0} and arr i: {1} after swap", arr[min_indx], arr[i]);
                Console.WriteLine();
            }
        }
        static void PrintArray(int[] arr)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
