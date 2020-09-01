using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace StudentArrayListPractice
{
    public class StudentManagement
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList() ;
            studentList.Add(new Student { Name = "Johnny Cage", Age = 40 });
            studentList.Add(new Student { Name = "Tony Stark", Age = 43 });
            studentList.Add(new Student { Name = "Tom Cruise", Age = 50 });
            foreach(Student student in studentList)
            {
                Console.WriteLine(student.Name + " is " + student.Age);
            }
            studentList[0] = new Student { Name = "Tom Hidenson", Age = 35 };
            Console.WriteLine();
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.Name + " is " + student.Age);
            }
            Console.WriteLine();
            studentList.RemoveAt(1);
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.Name + " is " + student.Age);
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
