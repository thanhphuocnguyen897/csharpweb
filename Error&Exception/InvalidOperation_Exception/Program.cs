using System;
using System.Collections.Generic;

namespace InvalidOperation_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person() { Name = "NTP", Age = 23 });
            person.Add(new Person() { Name = "HNAK", Age = 23 });
            person.Add(new Person() { Name = "DQP", Age = 23 });
            person.Add(new Person() { Name = "THT", Age = 23 });
            person.Add(new Person() { Name = "NPS", Age = 23 });
            try
            {
                foreach(Person person1 in person)
                {
                    person.Remove(person1);
                }
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    public class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
