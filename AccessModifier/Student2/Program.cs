using System;

namespace Student2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Anh Khoa Hoang", "Hanoi", 23);
            Student student2 = new Student();
            student2.SetID(2);
            student2.SetName("Thanh Phuoc Nguyen");
            student2.SetAddress("Ho Chi Minh City");
            student2.SetAge(23);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.ReadKey();
        }
    }
}
