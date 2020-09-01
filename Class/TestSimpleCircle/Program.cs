using System;

namespace TestSimpleCircle
{
    public class TestSimpleCircle
    {
        public static void Main(string[] args)
        {
            SimpleCircle circle1 = new SimpleCircle();
            Console.WriteLine("The area of the circle has radius " + circle1.radius + "is " + circle1.GetArea());
            SimpleCircle circle2 = new SimpleCircle(25);
            Console.WriteLine("The area of the circle has radius " + circle2.radius + "is " + circle2.GetArea());

            SimpleCircle circle3 = new SimpleCircle(125);
            Console.WriteLine("the area of the circle has radius " + circle3.radius + "is " + circle3.getarea());
            circle2.radius = 100;
            Console.WriteLine("The area of the circle has radius " + circle2.radius + "is " + circle2.GetArea());
        }
    }
    class SimpleCircle
    {
        public double radius;
        public SimpleCircle()
        {
            radius = 1;
        }
        public SimpleCircle(double newRadius)
        {
            radius = newRadius;
        }
        public double GetArea()
        {
            return Math.Round(radius * radius * Math.PI, 3);
        }
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }
    }
}
