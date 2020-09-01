using System;
using System.Collections.Generic;
using System.Text;

namespace CircelInheritance
{
    public class Cylinder : Circle
    {
        private double height;
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public Cylinder()
        {

        }
        public Cylinder(double height, double radius, String color) : base(radius, color)
        {
            this.height = height;
        }
        public double Volume()
        {
            return Math.Pow(this.GetRadius(), 2) * Math.PI * this.height;
        }
        public override string ToString()
        {
            return "Cyliner has heigth: "
                + GetHeight()
                + ", which subclass with: "
                + base.ToString();
        }
    }
}
