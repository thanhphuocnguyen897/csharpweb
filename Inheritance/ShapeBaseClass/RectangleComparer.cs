using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class RectangleComparer : IComparer<Rectangle>
    {
        public int Compare(Rectangle r1, Rectangle r2)
        {
            if (r1.GetPerimeter() > r2.GetPerimeter())
                return 1;
            else if (r1.GetPerimeter() < r2.GetPerimeter()) 
                return -1;
            else 
                return 0;
        }
    }
}
