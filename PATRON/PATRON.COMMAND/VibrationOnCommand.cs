using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMMAND
{
    public class VibrationOnCommand : Command
    {
        private Vibration vibration;
        public VibrationOnCommand(Vibration vibration)
        {
            this.vibration = vibration;
        }
        public void Execute()
        {
            this.vibration.turnOn();
        }
    }
}
