using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class XmlTransformation : IDisposable
    {
        private string _file;

        public XmlTransformation(string file)
        {
            _file = file;
        }
        public bool Apply(XmlTransformableDocument doc)
        {
            return true;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
