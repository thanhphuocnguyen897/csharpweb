using System;
using System.Threading;
using Timers = System.Timers;

namespace Get_and_Control_Thread
{
    class TestPriority
    {
        static void Main(string[] args)
        {
            PriorityTest priorityTest = new PriorityTest();
            Thread thread1 = new Thread(priorityTest.ThreadMethod);
            thread1.Name = "Thread One";
            Thread thread2 = new Thread(priorityTest.ThreadMethod);
            thread2.Name = "Thread Two";
            thread2.Priority = ThreadPriority.BelowNormal;
            Thread thread3 = new Thread(priorityTest.ThreadMethod);
            thread3.Name = "Thread Three";
            thread3.Priority = ThreadPriority.AboveNormal;

            thread1.Start();
            thread2.Start();
            thread3.Start();
            //Allow counting for 10 second.
            Thread.Sleep(10000);
            priorityTest.LoopSwitch = false;
        }
    }
    public class PriorityTest
    {
        static bool loopSwitch;
        [ThreadStatic] static long threadCount = 0;

        public PriorityTest()
        {
            loopSwitch = true;
        }
        public bool LoopSwitch
        {
            set { loopSwitch = value; }
        }
        public void ThreadMethod()
        {
            while (loopSwitch)
            {
                threadCount++;
            }
            Console.WriteLine("{0,-11 with {1,11} priority has a count = {2,13}", 
                Thread.CurrentThread.Name,
                Thread.CurrentThread.Priority.ToString(), 
                threadCount.ToString("N0"));
        }
    }
}
