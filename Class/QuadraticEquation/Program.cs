using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter a, b, c: ");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());
            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            Console.WriteLine(equation.GetResult());
        }
    }
    public class QuadraticEquation
    {
        private double a, b, c;
        public QuadraticEquation(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double GetDiscriminant()
        {
            return Math.Round(Math.Pow(this.B, 2) - (4 * this.A * this.C), 3);
        }
        public double GetRoot1()5rtttttdcx
        {
            return Math.Round((-this.B + Math.Sqrt(Math.Pow(this.B, 2) - (4 * this.A * this.C))) / 2 * this.A, 3);
        }
        public double GetRoot2()
        {
            return Math.Round((-this.B - Math.Sqrt(Math.Pow(this.B, 2) - (4 * this.A * this.C))) / 2 * this.A, 3);
        }

        public string GetResult()
        {
            if(this.GetDiscriminant() < 0)
            {
                return "The equation has no root!";
            }
            else if(this.GetDiscriminant() == 0)
            {
                return $"The equation has one root is: {this.GetRoot1()}";
            }
            else
            {
                return $"The equation has double roots is: {this.GetRoot1()} and {this.GetRoot2()}";
            }
        }
    }
}
