using System;

namespace FindMinValueMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter size of array: ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Size should not exceed 20!");
                }
            } while (size > 20);
            int i = 0;
            array = new int[size];
            while(i < array.Length)
            {
                Console.Write("Enter element {0} : ", (i + 1));
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            int index = MinValue(array);
            Console.WriteLine("Min value is {0} at {1} element.", array[index], index + 1);
        }
        public static int MinValue(int[] array)
        {
            int Min = array[0];
            int index = 0;
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] < Min)
                {
                    Min = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
