using System;

namespace LinearFinding
{
    class GFG
    {
        public static int Search(int[] arr, int x)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40, 35 };
            int x = 10;
            int result = Search(arr, x);
            if (result == -1)
            {
                Console.WriteLine("Element is not present in array.");
            }
            else
                Console.WriteLine("Element is present at index " + result);
        }
    }
}
