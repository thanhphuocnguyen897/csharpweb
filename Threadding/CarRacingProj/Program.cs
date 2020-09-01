using System;
using System.Threading;

namespace CarRacingProj
{
    class Program
    {
        static void Main()
        {
            Car carA = new Car("wantedOracle");
            Car carB = new Car("shadowKiller");
            Car carC = new Car("lightConquerer");

            Thread thread1 = new Thread(carA.Run);
            Thread thread2 = new Thread(carB.Run);
            Thread thread3 = new Thread(carC.Run);

            Console.WriteLine("Distance: 100KM");
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadKey();
        }
    }
    public class Car
    {
        private string Name;
        public static int DISTANCE = 100;
        public static int STEP = 2;
        //private int speed;


        //public int Speed { get => speed; set => speed = value; }

        public Car(string name)
        {
            this.Name = name;
        }
        public void Run()
        {
            //Started distacne
            int startPoint = 0;
            //Start Time
            DateTime startTime = DateTime.Now;

            //Check if Destination < run distance
            while(startPoint < DISTANCE)
            {
                try
                {
                    //Random speed of racing car.
                    int speed = (new Random()).Next(20);
                    //Calculate ran distance;
                    startPoint += speed;
                    //Build graphic
                    String log = "|";
                    int percentLap = (startPoint * 100) / DISTANCE;
                    for(int i = 0; i < DISTANCE; i += STEP)
                    {
                        if(percentLap >= i + STEP)
                        {
                            log += "=";
                        }
                        else if(percentLap >= i && percentLap < i + STEP)
                        {
                            log += "o";
                        }
                        else
                        {
                            log += "-";
                        }
                    }
                    log += "|";
                    
                    Console.WriteLine("Car " + this.Name + " : " + log + " " + Math.Min(DISTANCE, startPoint) + "KM");
                    Console.WriteLine("Loading... " + percentLap + "%");
                    Thread.Sleep(1000);
                }
                catch(ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Car" + this.Name + " broken...");
                    break;
                }
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Car " + this.Name + " Finish in " + (endTime - startTime) + "s.");
        }
    }
}
