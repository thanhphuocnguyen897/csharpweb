using System;
using System.Collections.Generic;
using System.Text;

namespace Student2
{
    class Student
    {

        private int id;
        private string name;
        private string address;
        private int age;

        public Student()
        {

        }
        public Student(int _id, string _name, string _address, int _age)
        {
            this.id = _id;
            this.name = _name;
            this.address = _address;
            this.age = _age;
        }
        
        public int GetID()
        {
            return this.id;
        }
        public void SetID(int _id)
        {
            this.id = _id;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string _name)
        {
            this.name = _name;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public void SetAddress(string _address)
        {
            this.address = _address;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int _age)
        {
            this.age = _age;
        }
        public override string ToString()
        {
                return "ID: " + id + ", Name: " + name + ", Address : " + address + ", Age: " + age;
        }
    }
}
