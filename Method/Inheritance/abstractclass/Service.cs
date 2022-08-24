using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.abstractclass
{
    class Service : Crud
    {
        public override void create()
        {
            throw new NotImplementedException();
        }

        public override void read()
        {
            throw new NotImplementedException();
        }

        public void detil()
        {
            delete();
        }
    }
}
