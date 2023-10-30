using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.COMMAND
{
    public class Device
    {
        private Command commandA;
        private Command commandB;

        public void setCommandA(Command command)
        {
            this.commandA = command;
        }
        public void setCommandB(Command command)
        {
            this.commandB = command;
        }

        public void pressButtonA()
        {
            commandA.Execute();
        }
        public void pressButtonB()
        {
            commandB.Execute();
        }
    }
}
