using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.generic
{
    class ImplGenericInterface : IGenericInterface<string>
    {
        public string getData()
        {
            throw new NotImplementedException();
        }

        public void setData(string data)
        {
            throw new NotImplementedException();
        }
    }
}
