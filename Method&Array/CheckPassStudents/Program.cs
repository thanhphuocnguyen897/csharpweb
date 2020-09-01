using System;

namespace CheckPassStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] score;
            do
            {
                Console.Write("Enter a size: ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                {
                    Console.WriteLine("Size should not exceed 30.");
                }
            } while (size > 30);
            score = new int[size];
            int i = 0;
            while(i < score.Length)
            {
                Console.Write("Enter score of students: ");
                score[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            int count = 0;
            Console.WriteLine("List of score: ");
            for(int j = 0; j < score.Length; j++)
            {
                Console.WriteLine(score[j] + "\t");
                if(score[j] >= 5 && score[j] <= 10)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of students pass: " + count);
            Console.ReadLine();
        }
    }
}
