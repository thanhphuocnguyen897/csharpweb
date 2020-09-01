using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class Square : Rectangle
    {
        private double size;

        public double Size { get => size; set => size = value; }

        public Square()
        {

        }
        public Square(double side) : base(side, side)
        {

        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {

        }
        public override void SetWidth(double width)
        {
            this.Size = width;
        }
        public override void SetLength(double length)
        {
            this.Size = length;
        }
        public void HowtoColor()
        {
            if (Filled)
            {
                Console.WriteLine("Color all four sides.");
            }
        }
        public override string ToString()
        {
            return "A square with side = "
                + this.Size
                + ", which is a subclass of "
                + base.ToString();
        }
    }
}
