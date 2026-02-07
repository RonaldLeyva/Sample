using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class XmlTransformationException: Exception
    {
        public XmlTransformationException(string mensaje) :base(mensaje)
        {
            
        }
    }
}
