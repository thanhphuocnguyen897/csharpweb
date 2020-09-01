using System;

namespace BinarySearch2
{
    class GFG2
    {
        static int BinarySearch2(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while(l <= r)
            {
                int m = l + (r - 1) / 2;
                // Check if x is present at mid
                if (arr[m] == x)
                {
                    return m;
                }
                // If x greater, ignore left half  
                else if (arr[m] < x)
                {
                    l = m + 1;
                }
                else
                    r = m - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result = BinarySearch2(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }
    }
}
