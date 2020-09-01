using System;
using System.Collections.Generic;
using System.Text;

namespace baseKeyDemo
{
    public class Users
    {
        public string name = "Takeshi Omah";
        public string location = "Tokyo, Japan";
        public int age = 23;
        public Users() { }
        public Users(string name, string location, int age)
        {
            this.name = name;
            this.location = location;
            this.age = age;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    public class Details: Users
    {
        public Details()
        {

        }
        public Details(string name, string location, int age) : base(name, location, age)
        {

        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Age: {0}", base.age);
        }
    }
}
