using System;

namespace DivideByZero_ qException
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
