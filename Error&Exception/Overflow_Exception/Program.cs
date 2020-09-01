using System;

namespace Overflow_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 990000000;
            int number2 = 990000000;
            try
            {
                int result = number1 * number2;
                Console.WriteLine(result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
