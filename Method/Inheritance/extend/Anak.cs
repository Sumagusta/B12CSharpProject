using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.extend
{
    class Anak : OrangTua
    {
        public void terimaWarisan()
        {
            Anak a = new Anak();
            a.warisan1();
            string namaOrtu = a.namaOrangTua;
            Console.WriteLine(namaOrtu);
        }
    }
}
