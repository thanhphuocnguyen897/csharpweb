using System;

namespace DeleteElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int elem;
            int index = 0;
            Random rand = new Random(); 
            Console.Write("Enter element and index to delete");
            elem = Int32.Parse(Console.ReadLine());
            for(int i =0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10);
            }
            for(int i = 0; i < array.Length; i++)
            {
                if(elem == array[i])
                {
                    index = i;
                    while (index < array.Length -1)
                    {
                        array[index] = array[index + 1];
                        index++;
                    }
                }
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
