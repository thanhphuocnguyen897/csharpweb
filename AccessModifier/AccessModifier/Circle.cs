using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    public class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            this.color = "red";
        }
        private internal double GetRadius()
        {
            return this.radius;
        }
        private internal string GetColor()
        {
            return this.color;
        }
    }
}
