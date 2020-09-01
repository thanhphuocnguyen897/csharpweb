using System;

namespace CarStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mazda3", "Skyactiv 3");
            Console.WriteLine(Car.numberofCars);
            Car car2 = new Car("Mazda 6", "Skyactiv 6");
            Console.WriteLine(Car.numberofCars);
            Console.ReadLine();
        }
    }
}
