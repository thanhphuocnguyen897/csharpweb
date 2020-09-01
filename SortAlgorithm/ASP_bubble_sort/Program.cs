using System;

namespace ASP_bubble_sort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 640, 4, 250, -12, 232, 11, -90 };
            BubbleSort(arr);
            Console.WriteLine("Sorted array");
            PrintArray(arr);
        }
        static void BubbleSort(int [] arr)
        {
            int i, j, temp;
            int lenght = arr.Length;
            bool swapped;
            int count = 0;
            for(i = 0; i < lenght-1; i++)
            {
                swapped = false;
                for(j = 0; j < lenght - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1]
                        Console.WriteLine("before swap: arr[j] = {0} and arr[j+1] = {1}", arr[j], arr[j + 1]);
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                        swapped = true;
                        Console.WriteLine("after swap: arr[j] = {0} and arr[j+1] = {1}", arr[j], arr[j + 1]);
                    }
                }
                // IF no two elements were   
                // swapped by inner loop, then break  
                Console.WriteLine("swap??" + swapped);
                if (swapped == false)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine("count is:" + count);
        }
        static void PrintArray(int [] arr)
        {
            int i;
            for(i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
