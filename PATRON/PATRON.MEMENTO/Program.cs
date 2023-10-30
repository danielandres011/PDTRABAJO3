using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON.MEMENTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planificacion planificacion = new Planificacion();
            Stack<IMemento> planificacionHistorial = new Stack<IMemento>();

            planificacion.CambiarEstado("Creada");
            planificacionHistorial.Push(planificacion.crearMemento());
            Console.WriteLine(planificacion.getEstado());
            planificacion.CambiarEstado(" Analizada por el trabajador");
            planificacionHistorial.Push(planificacion.crearMemento());
            Console.WriteLine(planificacion.getEstado());
            planificacion.CambiarEstado(" Enviada para autorización");
            planificacionHistorial.Push(planificacion.crearMemento());
            Console.WriteLine(planificacion.getEstado());
            planificacion.CambiarEstado(" Autorizada por el supervisor");
            Console.WriteLine(planificacion.getEstado());

            planificacion.restablecerMemento(planificacionHistorial.Pop());
            Console.WriteLine(planificacion.getEstado());
            planificacion.restablecerMemento(planificacionHistorial.Pop());
            Console.WriteLine(planificacion.getEstado());
            planificacion.restablecerMemento(planificacionHistorial.Pop());
            Console.WriteLine(planificacion.getEstado());

            Console.ReadKey();
        }
    }
}
