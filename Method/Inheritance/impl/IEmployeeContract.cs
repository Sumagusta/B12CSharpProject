using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.impl
{
    // inheritance, ada 3 = instance, extends, implements
    // interface = file yang semua datanya merupakan abstract / tidak boleh diisi.
    interface IEmployeeContract
    {
        public void biodata();
        public void salary(int salary);
        public void durasi(int tahun);
        public void jabatan(string jabatan);
    }
}
