using System;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();
            int[] array = new int[20];
            Random rand = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 50);
                Console.Write(array[i] + " ");
            }
            selectionSort(ref array);
            Console.WriteLine("Sorted array: \n");
            printArray(ref array);
            stopwatch.Stop();
            Console.WriteLine("Time used: " + stopwatch.GetElapsedTime());
        }
        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void selectionSort(ref int[] array)
        {
            int i, j, min;
            for (i = 0; i < array.Length; i++)
            {
                min = i;
                for(j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[min])
                    {
                        min = j;
                    }
                    swap(ref array[min], ref array[i]);
                }
            }
        }
        static void printArray(ref int[] array)
        {
            int i;
            for(i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime EndTime { get => endTime; set => endTime = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }

        public StopWatch()
        {

        }

        public DateTime Start()
        {
            DateTime resetTime = DateTime.Now;
            this.StartTime = resetTime;
            return this.StartTime;
        }
        public DateTime Stop()
        {
            DateTime setTime = DateTime.Now;
            this.EndTime = setTime;
            return this.EndTime;
        }
        
        public TimeSpan GetElapsedTime()
        {
            TimeSpan value = this.EndTime.Subtract(this.StartTime);
            return value;
        }
    }
}
