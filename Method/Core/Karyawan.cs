using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Core
{
    public class Karyawan
    {
        private string nama = "Hardiyan";
        private int usia;
        private int salary;

        public void setNama(string nama)
        {
            this.nama = nama;
        }

        public string getNama()
        {
            return nama;
        }
    }
}
