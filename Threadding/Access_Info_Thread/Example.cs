using System;
using System.Threading;

namespace Access_Info_Thread
{
    class Example
    {
        static Object obj = new Object();
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(ShowThreadInfomation);
            var th1 = new Thread(ShowThreadInfomation);
            th1.Start();
            var th2 = new Thread(ShowThreadInfomation);
            th2.IsBackground = true;
            th2.Start();
            Thread.Sleep(500);
            ShowThreadInfomation(null);
        }
        private static void ShowThreadInfomation(Object state)
        {
            lock (obj)
            {
                var th = Thread.CurrentThread;
                Console.WriteLine("Managed thread #{0}: ", th.ManagedThreadId);
                Console.WriteLine("  Background thread: {0}", th.IsBackground);
                Console.WriteLine("  Thread pool thread: {0}", th.IsThreadPoolThread);
                Console.WriteLine("  Priority: {0}", th.Priority);
                Console.WriteLine("  Culture: {0}", th.CurrentCulture.Name);
                Console.WriteLine(" UI Culture: {0}", th.CurrentUICulture.Name);
                Console.WriteLine();
            }
        }
    }
}
