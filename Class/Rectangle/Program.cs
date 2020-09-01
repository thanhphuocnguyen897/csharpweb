using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width and the height: ");
            double width = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Your rectangle \n" + rectangle.Display());
            Console.WriteLine("erimeter is " + rectangle.GetPerimeter());
            Console.WriteLine("Area is " + rectangle.GetArea());
        }
    }
    public class Rectangle
    {
        double width, height;

        public Rectangle() { 
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return Math.Round(this.width * this.height, 3);
        }
        public double GetPerimeter()
        {
            return Math.Round((this.width + this.height) * 2, 3);
        }
        public string Display()
        {
            return "Rectangle{" + "width= " + width + ",height= " + height + "}";
        }
    }
}
