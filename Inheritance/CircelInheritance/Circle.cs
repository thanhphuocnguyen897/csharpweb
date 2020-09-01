using System;
using System.Collections.Generic;
using System.Text;

namespace CircelInheritance
{
    public class Circle
    {
        private double radius;
        private String color;

        public double GetRadius()
        {
            return radius;
        }
        public String GetColor()
        {
            return color;
        }
        public virtual void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public virtual void SetColor(String color)
        {
            this.color = color;
        }

        public Circle()
        {

        }
        public Circle(double radius, String color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetArea()
        {
            return Math.Pow(this.radius, 2) * Math.PI;
        }
        public override string ToString()
        {
            return "A Circle with radius: " 
                + GetRadius()
                + "and color:"
                + GetColor();
        }
    }
}
