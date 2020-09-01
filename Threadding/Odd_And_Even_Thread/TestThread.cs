using System;
using System.Threading;

namespace Odd_And_Even_Thread
{
    class TestThread
    {
        static Thread oddThread, evenThread, procThread;
        public static void Main()
        {
            OddThread odd = new OddThread();
            EvenThread even = new EvenThread();
            procThread = new Thread(new ThreadStart(ThreadProc));
            oddThread = new Thread(new ThreadStart(odd.Run));
            oddThread.Name = "oddThread";
            oddThread.Start();
            evenThread = new Thread(new ThreadStart(even.Run));
            evenThread.Name = "evenThread";
            evenThread.Start();
            
        }
        private static void ThreadProc()
        {
            Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name == "evenThread" &&
               oddThread.ThreadState != ThreadState.Unstarted)
                oddThread.Join();
            Thread.Sleep(2000);
            Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("oddThread: {0}", oddThread.ThreadState);
            Console.WriteLine("evenThread: {0}\n", evenThread.ThreadState);
        }
    }
    public class OddThread
    {
        public void Run()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(10);
                }
            }
        }
    }
    public class EvenThread
    {
        public void Run()
        {
            for (int i = 0; i < 10; i++) 
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(15);
                }
            }
        }
    }
}
