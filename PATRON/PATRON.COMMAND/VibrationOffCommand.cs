using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMMAND
{
    public class VibrationOffCommand : Command
    {
        private Vibration vibration;

        public VibrationOffCommand(Vibration vibration)
        {
            this.vibration = vibration;
        }
        public void Execute()
        {
            this.vibration.turnOff();
        }
    }
}
