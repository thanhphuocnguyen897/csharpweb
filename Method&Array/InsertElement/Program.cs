using System;

namespace InsertElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int element;
            int index;
            Console.WriteLine("Enter element and index to insert: ");
            element = Int32.Parse(Console.ReadLine());
            index = Int32.Parse(Console.ReadLine());
            index--;
            if (index < 0 || index > array.Length - 1)
            {
                Console.WriteLine("Can't insert element in array!");
            }
            else
            {
                int[] array1 = new int[array.Length + 1];
                for(int i = 0; i < index; i++)
                {
                    array1[i] = array[i];
                }
                array1[index] = element;
                for (int i = index + 1; i < array1.Length; i++) 
                {
                    array1[i] = array[i-1];
                }
                for(int i = 0; i<array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }
            }
        }
    }
}
