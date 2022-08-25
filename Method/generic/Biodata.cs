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

        Stack<T> stk = new Stack<T>();
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
