using System;

namespace ACMDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicLib.Class1 pc = new PublicLib.Class1();
            int sum = pc.Sum(1, 2);
            Console.WriteLine(sum);
            InternalLib.Class1 ic = new InternalLib.Class1();
            sum = ic.Sum(1, 2);
            Console.WriteLine(sum);
        }
    }
}
