using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class WindowsServiceManager
    {
        public void DetenerServicio(string nombreServicio)
        {
            Console.WriteLine("Deteniendo el servicio: " + nombreServicio);
        }
    }
}
