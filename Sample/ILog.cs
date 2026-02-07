using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public interface ILog
    {
        void Info(string nombre, string mensaje = null);
        void Error(string mensaje, Exception ex = null);
    }
}
