using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");
        }
        //Khai báo biến cục bộ.
        static void Declarations(string[] args)
        {
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine(a + b + c);
        }
        //Khai báo hằng cục bộ:
        static void ConstantDeclarations(string[] args)
        {
            const float PI = 3.1415927f;
            const int R = 25;
            Console.WriteLine(PI * R * R);
        }
        //Câu lệnh hiển thị:
        static void Expressions(string[] args)
        {
            int i;
            i = 123;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
        }
        //Câu lệnh if:
        static void IfStatement(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine("One or more arguments");
            }
        }
        //Câu lệnh switch
        static void SwitchStatement(string[] args)
        {
            int n = args.Length;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No Arguments");
                    break;
                case 1:
                    Console.WriteLine("One Arguments");
                    break;
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
        //Câu lệnh While
        static void WhileStatements(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        //Câu lệnh Do:
        static void DoStatements(string[] args)
        {
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }
        //Câu lệnh For:
        static void ForStatements(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        //Câu lệnh Foreach
        static void ForeachStatements(string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine(s);
            }
        }
        //Câu lệnh Break:
        static void BreakStatement(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }
        //Câu lệnh Continue
        static void ContinueStatement(string[] args)
        {
            for(int i = 0; i<args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }
        //Câu lệnh goto:
        static void GotoStatement(string[] args)
        {
            int i = 0;
            goto check;
        loop:
            Console.WriteLine(args[i++]);
        check:
            if(i < args.Length)
            {
                goto loop;
            }
        }
        //Câu lệnh return:
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void ReturnStatement(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            return;
        }
        //Câu lệnh yield:
        //static System.Collections.Generic.IEnumerable Range(int start, int end) 
        //{
        //    for (int i = start; i < end; i++)
        //    {
        //        yield return i;
        //    }
        //    yield break;
        //}
        //static void YielStatement(string[] arg)
        //{
        //    foreach (int i in Range(-10, 10))
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //Câu lệnh Try and Throw:
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
        static void TryCatch(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Two numbers required");
                }
                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Divide(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
        //Câu lệnh Checked và UnChecked:
        static void CheckedandUnChecked(string[] args)
        {
            int x = int.MaxValue;
            unchecked
            {
                Console.WriteLine(x + 1); //overflow
            }
            checked
            {
                Console.WriteLine(x + 1);//Exception
            }
        }
        //Câu lệnh lock:
        class Account
        {
            decimal balance;
            private readonly object sync = new object();
            public void Withdraw(decimal amount)
            {
                lock (sync)
                {
                    if (amount > balance)
                    {
                        throw new Exception("Insufficient funds");
                    }
                    balance -= amount;
                }
            }
        }
        //Câu lệnh using:
        static void UsingStatement(string[] args)
        {
            using(TextWriter w = File.CreateText("text.txt"))
            {
                Console.WriteLine("Line One");
                Console.WriteLine("Line Two");
                Console.WriteLine("Line Three");
            }
        }
    }
}
