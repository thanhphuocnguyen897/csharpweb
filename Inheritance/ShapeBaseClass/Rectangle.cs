using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetLength()
        {
            return this.length;
        }
        public virtual void SetLength(double length)
        {
            this.length = length;
        }
        public Rectangle()
        {

        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, String color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double GetArea()
        {
            return this.width * this.length;
        }
        public double GetPerimeter()
        {
            return 2 * (this.width + this.length);
        }
        public void Resize(double percent)
        {
            this.width = this.width * (percent / 100);
            this.length = this.length * (percent / 100);
        }
        public override string ToString()
        {
            return "A rectangle with width: "
                + this.width
                + " and length = "
                + this.length
                + ", which is a subclass of: "
                + base.ToString();
        }
    }
}
