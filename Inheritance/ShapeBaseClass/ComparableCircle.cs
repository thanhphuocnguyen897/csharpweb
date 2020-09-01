using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeBaseClass
{
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle() { }
        public ComparableCircle(double radius) : base(radius) { }
        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, false) { }
        public int CompareTo(ComparableCircle o)
        {
            if (Radius > o.Radius) return 1;
            else if (Radius < o.Radius) return -1;
            else return 1;
        }
    }
}
