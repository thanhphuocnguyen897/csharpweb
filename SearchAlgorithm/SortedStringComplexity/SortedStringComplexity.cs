using System;
using System.Globalization;

namespace SortedStringComplexity
{
    class SortedStringComplexity
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();
            int lenght = inputString.Length;
            Console.WriteLine(lenght);
            int count = 0;
            for(int i = 0; i<lenght; i++)
            {
                if(inputString[0] == inputString[i])
                {
                    count = i - 0;
                    Console.Write(i + " ");
                    for(int j = 0; j<i; j++)
                    {
                        Console.Write(inputString[j]);
                    }
                }
            }
        }
    }
}
