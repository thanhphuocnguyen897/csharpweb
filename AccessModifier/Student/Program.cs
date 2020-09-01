using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();
            Student s1 = new Student(111, "Khoa");
            Student s2 = new Student(222, "Tuan");
            Student s3 = new Student(333, "Nam");
            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
}
