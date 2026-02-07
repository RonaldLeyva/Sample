using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class ConsoleLog : ILog
    {
        public void Error(string mensaje, Exception ex = null)
        {
            Console.WriteLine("Error: " + mensaje + " " + (ex != null ? ex.Message : ""));
        }

        public void Info(string nombre, string mensaje)
        {
            Console.WriteLine("Información del servicio : " + nombre + " " + mensaje);
        }
    }
}
