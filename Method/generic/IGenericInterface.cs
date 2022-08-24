using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.generic
{
    interface IGenericInterface<T>
    {
        public void setData(T data);
        public T getData();
    }
}
