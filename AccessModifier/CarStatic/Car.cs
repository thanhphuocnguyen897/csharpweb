using System;
using System.Collections.Generic;
using System.Text;

namespace CarStatic
{
    public class Car
    {
        private string name;
        private string engine;
        public static int numberofCars;
        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberofCars++;
        }
        //getter and setter.
    }
}
