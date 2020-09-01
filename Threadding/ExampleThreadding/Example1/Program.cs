using System;
using System.Diagnostics;
using System.Threading;

namespace Example1
{
    class Program
    {
        static void Main()
        {
            var th = new Thread(ExecuteInForeground);
            //th.IsBackground = true;
            th.Start(10000);
            Thread.Sleep(1000);
            Console.WriteLine("Main thread ({0}) exiting...", Thread.CurrentThread.ManagedThreadId);
        }
        //Có tham số truyền vào hoặc k có tham số obj
        private static void ExecuteInForeground(Object obj)
        {
            int interval;
            try
            {
                interval = (int)obj;
            }
            catch (InvalidCastException)
            {
                interval = 5000;
            }
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Thread {0}: {1}, Priority {2}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.ThreadState,
                Thread.CurrentThread.Priority);
            do
            {
                Console.WriteLine("Thread {0}: Elasped {1:N2} seconds",
                    Thread.CurrentThread.ManagedThreadId,
                    sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= interval);
            sw.Stop();
        }
    }
}
