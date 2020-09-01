using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class Shape
    {
        private String color;
        private bool filled;
        public Shape()
        {
            Color = "green";
            Filled = true;
        }
        public Shape(String color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public String Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public override String ToString()
        {
            if (this.Filled)
            {
                return $"A shape with color of {this.Color} and filled.";
            }
            else
            {
                return $"A shape with color of {this.Color} and not filled.";
            }
        }
    }
}
