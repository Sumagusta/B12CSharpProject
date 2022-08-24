using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.generic
{
    class Biodata <T>
    {
        private T obj;

        public Biodata(T obj)
        {
            this.obj = obj;
        }

        public T getBiodata()
        {
            return obj;
        }
    }
}
