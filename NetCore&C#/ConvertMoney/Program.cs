using System;

namespace ConvertMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            Console.Write("Enter Money (USA): ");
            int USA = Convert.ToInt32(Console.ReadLine());
            int VND = USA * rate;
            Console.WriteLine("Amounts: {0} VNĐ", VND);
        }
    }
}
