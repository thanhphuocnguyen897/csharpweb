using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class Triangle : Shape
    {
        private double side1, side2, side3 = 1;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }
        public Triangle()
        {

        }
        public Triangle(double side1, double side2, double side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }
        public double GetArea()
        {
            return Math.Sqrt(GetPerimeter() * (GetPerimeter() - Side1) * (GetPerimeter() - Side2) * (GetPerimeter() - Side3));
        }
        public double GetPerimeter()
        {
            return (this.Side3 + this.Side2 + this.Side1);
        }
        public override string ToString()
        {
            return "A Triangle with a, b, c = "
                + Side1 +" "+ Side2 +" " + Side3 +" " 
                + ", which is subclass of "
                + base.ToString();
        }
    }
}
