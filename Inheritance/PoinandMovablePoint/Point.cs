using System;
using System.Collections.Generic;
using System.Text;

namespace PoinandMovablePoint
{
    public class Point2D
    {
        private float x, y = 0.0f;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public float[] GetXY()
        {
            float[] XY = { this.X, this.Y };
            return XY;
        }
        public void SetXY(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point2D()
        {

        }
        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return $"(x {this.X}, y {this.Y})";
        }
    }
    public class MovablePoint : Point2D
    {
        private float xSpeed, ySpeed = 0.0f;

        public float XSpeed { get => xSpeed; set => xSpeed = value; }
        public float YSpeed { get => ySpeed; set => ySpeed = value; }
        public MovablePoint(float xSpeed, float ySpeed, float X, float Y) : base(X, Y)
        {
            this.XSpeed = xSpeed;
            this.YSpeed = ySpeed;
        }
        public MovablePoint(float X, float Y) : base(X, Y)
        {

        }
        public float[] GetSpeed()
        {
            float[] xySpeed = {this.XSpeed, this.YSpeed };
            return xySpeed;
        }
        public override string ToString()
        {
            return "This point has "
                + " x, y: " + GetXY() + " speed of x, y: " + GetSpeed()
                + base.ToString();
        }
        public void Move()
        {
            Console.WriteLine("This pointed has moved to x: {0} and y: {1}",(X+=XSpeed),(Y+=YSpeed));
        }
    }
}
