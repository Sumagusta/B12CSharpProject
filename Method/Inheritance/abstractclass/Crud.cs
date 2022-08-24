using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.abstractclass
{
    // abstract file yang bisa menerima method abstract dan concrete sekaligus
    abstract class Crud
    {
        public Crud()
        {

        }
        public abstract void create();
        public abstract void read();
        public void delete()
        {
            Console.WriteLine("Delete Data Success");
        }
    }
}
