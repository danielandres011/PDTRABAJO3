using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.MEMENTO
{
    public class Memento : IMemento
    {
        string estado;

        public Memento(string estado)
        {
            this.estado = estado;
        }

        public string getEstado()
        {
            return estado;
        }
    }
}
