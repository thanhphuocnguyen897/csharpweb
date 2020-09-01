using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class Circle : Shape
    {
        private double radius = 1.0;

        public double Radius { get => radius; set => radius = value; }

        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            this.Radius = radius;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return Radius * 2 * Math.PI;
        }
        public void Resize(double percent)
        {
             Radius = Radius * (percent / 100);
        }
        public override string ToString()
        {
            return "A circle with radius ="
                + this.Radius
                + " which is subclass of "
                + base.ToString();
        }
    }
}
