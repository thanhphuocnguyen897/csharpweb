using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    decimal price = 169.32m;
        //    Console.WriteLine("The cost is {0:Q2}.", price);
        //}
        //catch (System.FormatException ex)
        //{
        //    System.Console.WriteLine(ex);
        //}
        try
        {
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                int a = 39;
                int b = 0;
                Console.WriteLine("Thuc hien phep chia");
                int c = a / b;
            }
            catch (FormatException e)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Xử lý ngoại lệ FormatException");
            }
        }
        catch (ArithmeticException e)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Xử lý ngoại lệ ArithmeticException");
        }

        Console.WriteLine("tiep tuc chuong trinh..");
    }
}