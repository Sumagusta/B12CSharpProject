using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.impl
{
    class EmployeePertama : IEmployeeContract
    {
        public void biodata()
        {
            Console.WriteLine("Nama : Geo\n Country : China");
        }

        public void durasi(int tahun)
        {
            Console.WriteLine("Durasi Kerja : "+tahun);
        }

        public void jabatan(string jabatan)
        {
            Console.WriteLine("Jabatan : {0}", jabatan);
        }

        public void salary(int salary)
        {
            Console.WriteLine("salary : {0}", salary);
        }

        public void keluarga()
        {
            Console.WriteLine("Keluarga Bahagia");
        }
    }
}
