using System;

namespace TheBiggestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.Write("Enter size of array: ");
                size = Int32.Parse(Console.ReadLine());
                if(size > 20)
                {
                    Console.WriteLine("Size should not exceed 20");
                } 
            } while (size > 20);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Property list: ");
            int index = 1;
            int max = array[0];
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine((j + 1) + ":" + array[j]);
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("element: {0} is max with value: {1}", index, max);

        }
    }
}
