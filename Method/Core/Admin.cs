using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Core
{
    public class Admin
    {
        public void biodataKaryawan()
        {
            Karyawan biodata = new Karyawan();
            //biodata.setNama("Mulyono");

            Console.WriteLine(biodata.getNama());
        }

        public void divisiBio()
        {
            Divisi div = new Divisi();
            string name = div.name = "Robert";
            int member = div.member = 10;

            div.prestasi = "divisi terbaik";

            Console.WriteLine(name + " " + member);
            Console.WriteLine(div.member);
        }
    }
}
