using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class FileManager
    {
        public string UpdateFiles(string origen, string destino, string backup = null)
        {
            Console.WriteLine("Actualizando archivos");
            return "Actualización completada";
        }

        public void RemoveDirectoryContents(string path)
        {
            Console.WriteLine("Borrando el contenido del directorio");
        }
    }
}
