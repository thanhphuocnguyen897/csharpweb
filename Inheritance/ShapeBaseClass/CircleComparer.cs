using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBaseClass
{
    public class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.Radius > c2.Radius) return 1;
            else if (c1.Radius < c2.Radius) return -1;
            else return 0;
        }
    }
}
