using System;

namespace baseKeyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.GetInfo();

            Details d2 = new Details("Hoang Anh Khoa", "Viet Nam", 24);
            d2.GetInfo();
            Console.ReadKey();
        }
    }
}
