
using System;
using System.Threading;

namespace CreateThreadExcercise
{
    class Program
    {
        static void Main()
        {
            NumberGenerator generator = new NumberGenerator();
            generator.GetHashCode();
            Thread th1 = new Thread(new ThreadStart(generator.Run));
            th1.Name = "Highest";
            //th1.Priority = ThreadPriority.Highest;
            Console.WriteLine("ThreadState: {0}",
                          th1.ThreadState);
            Thread th2 = new Thread(new ThreadStart(generator.Run));
            th2.Name = "Lowest";
            //th2.Priority = ThreadPriority.Lowest;
            Console.WriteLine("ThreadState: {0}",
                          th2.ThreadState);
            th1.Start();
            Console.WriteLine("ThreadState: {0}",
                          th1.ThreadState);
            th2.Start();
            Console.WriteLine("ThreadState: {0}",
                          th2.ThreadState);
        }

    }
    public class NumberGenerator
    {
        public void Run()
        {
            for(decimal i =0; i < 10; i++)
            {
                Console.WriteLine(i);
                //Console.WriteLine(i.GetHashCode());
                Thread.Sleep(500);
                
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
