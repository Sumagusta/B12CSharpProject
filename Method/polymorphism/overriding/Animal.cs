using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.polymorphism.overriding
{
    public class Animal
    {
        public virtual void suara() // virtual agar boleh di override
        {
            Console.WriteLine("Suara hewan");
        }

    }
}
