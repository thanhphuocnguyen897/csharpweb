using System;

namespace Swapnumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            Console.WriteLine("Before Swaping: " + num1 + "and" + num2);

            Swap(num1, num2);
            Console.WriteLine("After Swapping: " + num1 + "and" + num2);
            Swap1(ref num1, ref num2);

            Console.WriteLine("After Swapping1: " + num1 + "and" + num2);

            int x;
            Getvalue(out x);
            Console.WriteLine(x);
        }
        public static void Swap(int n1, int n2)
        {
            Console.WriteLine("\t Inside the swap");
            Console.WriteLine("\tBefore swapping: " + n1 + "and" + n2);
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("\t After swapping: " + n1 + "and" + n2);
        }
        public static void Swap1(ref int n1,ref int n2)
        {
            Console.WriteLine("\t Inside the swap");
            Console.WriteLine("\tBefore swapping: " + n1 + "and" + n2);
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("\t After swapping: " + n1 + "and" + n2);
        }
        public static void Getvalue(out int x)
        {
            x = 5;
        }
    }
}
