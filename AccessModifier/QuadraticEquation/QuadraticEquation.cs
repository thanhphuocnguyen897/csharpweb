using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        private double a, b, c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public QuadraticEquation(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double GetDiscriminant()
        {
            double delta = Math.Pow(this.B,2) - (4*this.A*this.C);
            return Math.Round(delta, 3);
        }
        public double GetRoot1()
        {
            double root1 = (this.B - Math.Sqrt(GetDiscriminant())) / 2 * this.A;
            return Math.Round(root1,3);
        }
        public double GetRoot2()
        {
            double root2 = (-this.B - Math.Sqrt(GetDiscriminant())) / 2 * this.A;
            return root2;
        }
    }
}
