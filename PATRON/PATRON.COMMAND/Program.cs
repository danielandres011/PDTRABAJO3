using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMMAND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vibration vibration = new Vibration();
            Command vibrationOnCommand = new VibrationOnCommand(vibration);
            Command vibrationOffCommand = new VibrationOffCommand(vibration);

            Device device = new Device();
            device.setCommandA(vibrationOnCommand);
            device.pressButtonA();

            device.setCommandB(vibrationOffCommand);
            device.pressButtonB();
            Console.ReadKey();
        }
    }
}
