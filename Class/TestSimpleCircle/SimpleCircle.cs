//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TestSimpleCircle
//{
//    public class SimpleCircle
//    {
//        public static void Main(string[] args)
//        {
//            SimpleCircle circle1 = new SimpleCircle();
//            Console.WriteLine("The area of the circle has radius " + circle1.radius + "is " + circle1.GetArea());
//            SimpleCircle circle2 = new SimpleCircle(25);
//            Console.WriteLine("The area of the circle has radius " + circle2.radius + "is " + circle2.GetArea());

//            SimpleCircle circle3 = new SimpleCircle(125);
//            Console.WriteLine("The area of the circle has radius " + circle3.radius + "is " + circle3.GetArea());
//            circle2.radius = 100;
//            Console.WriteLine("The area of the circle has radius " + circle2.radius + "is " + circle2.GetArea());
//        }
//        double radius;
//        SimpleCircle()
//        {
//            radius = 1;
//        }
//        SimpleCircle(double newRadius)
//        {
//            radius = newRadius;
//        }
//        double GetArea()
//        {
//            return Math.Round(radius * radius * Math.PI, 3);
//        }
//        double GetPerimeter()
//        {
//            return 2 * radius * Math.PI;
//        }
//        void SetRadius(double newRadius)
//        {
//            radius = newRadius;
//        }
//    }
//}
