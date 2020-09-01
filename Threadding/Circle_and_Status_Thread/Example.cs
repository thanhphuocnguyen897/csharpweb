// C# program to illustrate the 
// states of the thread 
using System;
using System.Threading;

namespace Circle_and_Status_Thread
{
    public class Example
    {
        public static void Main()
        {
            //create instance for mythread() method
            MyThread obj = new MyThread();

            //Create and initial threads unstarted state
            Thread tr1 = new Thread(new ThreadStart(obj.mythread));
            Console.WriteLine("Thread state: {0}", tr1.ThreadState);

            //Running state
            tr1.Start();
            Console.WriteLine("Thread state: {0}", tr1.ThreadState);

            //tr1 is in suspended state
            tr1.Interrupt();
            Console.WriteLine("Thread state: {0}", tr1.ThreadState);

            //tr1 is resume to running state
            //tr1.Resume();
            //Console.WriteLine("Thread state: {0}", tr1.ThreadState);
        }
    }
    public class MyThread
    {
        //Non-static method
        public void mythread()
        {
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("My thread");
            }
        }
    }
}
