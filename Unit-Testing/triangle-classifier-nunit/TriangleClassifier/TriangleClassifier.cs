using System;

namespace TriangleClassifier
{
    public class TriangleClassifier
    {
        public string ClassifyTriangle(int side1, int side2, int side3)
        {
            bool IsEquilateral = side1 == side2 && side2 == side3;
            bool IsIsosceles = (side1 == side2) || (side1 == side3) || (side2 == side3);
            bool IsNormal = (side1 < side2 + side3 && side1 > Math.Abs(side3-side2))
                || (side2 < side1 + side3 && side2<Math.Abs(side3-side1)) || (side3 < side1+side2 && side3 > Math.Abs(side2-side1));
            if (IsEquilateral)
            {
                return "Equilateral triangle.";
            }
            else if (IsIsosceles)
            {
                return "Isosceles triangle.";
            }
            else if (IsNormal)
            {
                return "Normal triangle.";
            }
            else return "Not a triangle.";
        }
    }
}
