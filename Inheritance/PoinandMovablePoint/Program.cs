using System;

namespace PoinandMovablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            MovablePoint point1 = new MovablePoint(2, 35, 4, 6);
            Console.WriteLine("We have speed: " + point1.GetSpeed());
            Console.WriteLine("X Y before move:" + point1.GetXY()[0] + " and " + point1.GetXY()[1]);
            
            point1.Move();

            Console.WriteLine("Now it has location: " + point1.GetXY()[0] + " and " + point1.GetXY()[1]);
            
        }
    }
}
