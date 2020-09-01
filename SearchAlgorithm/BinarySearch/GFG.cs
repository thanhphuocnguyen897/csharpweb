using System;

namespace BinarySearch
{
    class GFG
    {
        static int BinarySearch(int[] arr,int l, int r, int x)
        {
            if (r >= 1)
            {
                int mid = 1 + (r - 1) / 2;
                // If the element is present at the  
                // middle itself
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] > x)
                {
                    return BinarySearch(arr, 1, mid - 1, x);
                }
                // Else the element can only be present  
                // in right subarray
                else
                    return BinarySearch(arr, mid + 1, l, x);
            }
            // We reach here when element is not present  
            // in array  
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 15, 20, 30 };
            int n = arr.Length;
            int x = 10;
            int result = BinarySearch(arr, 0, n - 1, x);
            if(result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
                Console.WriteLine("Element found at index " + result);
        }
    }
}
