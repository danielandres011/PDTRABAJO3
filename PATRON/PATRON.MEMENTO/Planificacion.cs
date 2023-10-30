using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.MEMENTO
{
    public class Planificacion
    {
        private string estado;

        public void CambiarEstado(string estado)
        {
            this.estado += estado;
        }

        public string getEstado()
        {
         return this.estado;
        }
        public Memento crearMemento()
        {
            return new Memento(this.estado);
        }
        public void restablecerMemento(object memento) {
            this.estado = ((Memento)memento).getEstado();
        }
    }
}
