using System;

namespace TVClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv1 = new TV();
            tv1.TurnOn();
            tv1.SetChannel(30);
            tv1.SetVolume(3);
            TV tv2 = new TV();
            tv2.TurnOn();
            tv2.ChannelUp();
            tv2.VolumeUp();
            Console.WriteLine("tv1's channel is " + tv1.channel + " an volume level is " + tv1.volumeLevel);
            Console.WriteLine("tv2's channel is " + tv2.channel + " an volume level is " + tv2.volumeLevel);
        }
    }
}
