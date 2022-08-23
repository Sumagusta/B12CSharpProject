using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.listabal
{
    class ListAbal : IListAbal
    {
        public void fungsi1()
        {
            Console.WriteLine("Logic Fungsi 1");            
        }

        public void fungsi2()
        {
            Console.WriteLine("Logic Fungsi 2");
        }

        public void fungsi3()
        {
            Console.WriteLine("Logic Fungsi 2");
        }

        public void fungsiTambahan()
        {
            Console.WriteLine("Logic Fungsi Tambahan");

        }

        public void runAllFunc()
        {
            fungsi1();
            fungsi2();
            fungsi3();
            fungsiTambahan();
        }
    }
}
