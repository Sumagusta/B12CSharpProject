using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.polymorphism.overriding
{
    class Kelelawar : Animal
    {
        public override void suara()
        {
            Console.WriteLine("Suara Kelelawar");
        }

        public virtual void movement()
        {
            Console.WriteLine("Terbang");
        }

        
    }
}
