using System;

namespace PATRON.COMMAND
{
    public class Vibration
    {
        Boolean vibrationOn = false;
        public void turnOn() {
            Console.WriteLine("Vibración: Encendida.");
            vibrationOn = true; 
        }
        public void turnOff()
        {
            Console.WriteLine("Vibración: Apagada.");
            vibrationOn = false;
        }
        public bool isVibrationOn() { 
            return vibrationOn; 
        }
    }
}
