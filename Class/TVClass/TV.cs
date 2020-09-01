using System;
using System.Collections.Generic;
using System.Text;

namespace TVClass
{
    public class TV
    {
        public int channel = 1;
        public int volumeLevel = 1;
        bool on = false;
        public TV() { 
        }
        public void TurnOn()
        {
            on = true;
        }
        public void TurnOff()
        {
            on = false;
        }
        public void SetChannel(int newChannel)
        {
            if (on && newChannel >= 1 && newChannel <= 120)
                channel = newChannel;
        }
        public void SetVolume(int newVolumeLevel)
        {
            if(on && newVolumeLevel >=0 && newVolumeLevel <= 7)
            {
                volumeLevel = newVolumeLevel;
            }
        }
        public void ChannelUp()
        {
            if (on && channel < 120)
                channel++;
        }
        public void ChannelDown()
        {
            if (on && channel > 0)
                channel--;
        }
        public void VolumeUp()
        {
            if(on && volumeLevel < 7)
            {
                volumeLevel++;
            }
        }
        public void VolumeDown()
        {
            if (on && volumeLevel > 0)
                volumeLevel--;
        }
    }
}
