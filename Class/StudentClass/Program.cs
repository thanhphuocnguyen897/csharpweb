using System;

namespace StudentClass
{
    class Test
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            Console.WriteLine("name? " + student.name); //Null
            Console.WriteLine("age? " + student.age); //0
            Console.WriteLine("isScienceMajor? " + student.isScienceMajor);//false
            Console.WriteLine("gender? " + student.gender);// null
        }
    }
    class Student
    {
        /*khi không gán giá trị cho các tham chiếu thì trả về Null*/
        public string name;
        public int age;
        public bool isScienceMajor;
        public char gender;
    }
}
