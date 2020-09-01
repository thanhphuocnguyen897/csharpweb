using System;

namespace FanClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(Fan.FAST, true, 10, "yellow") ; //fan1 is Instance
            Fan fan2 = new Fan(Fan.MEDIUM, false, 5, "blue"); //fan2 is Instance
            fan1.toString();
            fan2.toString();
        }
    }
    public class Fan
    {
        public const decimal SLOW = 1;
        public const decimal MEDIUM = 2;
        public const decimal FAST = 3;
        private decimal speed; //property
        private bool on;
        private double radius; //property
        private string color;

        public decimal Speed { get => speed; set => speed = value; } //getter and setter
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan()
        {
            this.speed = SLOW;
            this.on = false;
            this.radius = 5;
            this.color = "blue";
        }
        public Fan(decimal speed, bool on, double radius, string color)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }
        
        public void toString()
        {
            if (this.on)
            {
                Console.WriteLine(this.Speed +" "+ this.Color +" "+ this.Radius +" "+ " fan is on!");
            }
            else
            {
                Console.WriteLine(this.Color +" "+ this.Radius +" "+ " fan is off!");
            }
        }
    }
}
