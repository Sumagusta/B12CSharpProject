using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.extend
{
    class Cucu : Anak
    {

        public void cucuTerimaWarisan()
        {
            void a()
            {
                Console.WriteLine("Nested Method");
            }

            a();

            new Cucu().terimaWarisan();
        }
        
    }
}
