using System;
using System.Collections.Generic;
namespace ShapeBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Square square = new Square(2, "Yellow", true);
            //Console.WriteLine(square.GetArea());
            //square.HowtoColor();
            Rectangle rect = new Rectangle(4, 8.3, "Red", false);
            Circle circle = new Circle(5, "Blue", true);
            square.Resize(rand.NextDouble() * 100);
            rect.Resize(rand.NextDouble() * 100);
            circle.Resize(rand.NextDouble() * 100);
            Console.WriteLine(square.Size);
            Console.WriteLine("{0} and {1}", rect.GetLength(), rect.GetWidth());
            Console.WriteLine(circle.Radius);
            //Circle[] circles = new Circle[3];
            //ComparableCircle[] circles = new ComparableCircle[3];
            //circles[0] = new ComparableCircle(3.6);
            //circles[1] = new ComparableCircle();
            //circles[2] = new ComparableCircle(3.5, "indigo", false);
            //Console.WriteLine("Pre-sorted:");
            //foreach (ComparableCircle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}
            ////IComparer<Circle> circlecomparer = new CircleComparer();
            //Array.Sort(circles);
            //Console.WriteLine("After-sorted:");
            //foreach (ComparableCircle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}
            //Rectangle[] rects = new Rectangle[3];
            //rects[0] = new Rectangle(4.8, 5.2);
            //rects[1] = new Rectangle(2.6, 9.7);
            //rects[2] = new Rectangle(15.2, 0.7);
            //Console.WriteLine("Pre-sorted:");
            //foreach (Rectangle rect in rects)
            //{
            //    Console.WriteLine(rect);
            //}
            //IComparer<Rectangle> rectcomparer = new RectangleComparer();
            //Array.Sort(rects, rectcomparer);
            //Console.WriteLine("After-sorted:");
            //foreach (Rectangle rect in rects)
            //{
            //    Console.WriteLine(rect);
            //    Console.WriteLine(rect.GetPerimeter());
            //}

        }
    }
}
