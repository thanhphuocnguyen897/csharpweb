using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        private int rollno;
        private string name;
        private static string college = "Havard";

        public Student(int r, string n)
        {
            rollno = r;
            name = n;
        }

        public static void Change()
        {
            college = "HUSC";
        }

        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
