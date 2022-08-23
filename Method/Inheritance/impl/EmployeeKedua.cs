using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.impl
{
    class EmployeeKedua : IEmployeeContract
    {
        public void biodata() // concrete method
        {
            Console.WriteLine("Nama : Doni\n Country : Korea");
        }

        public void durasi(int tahun)
        {
            throw new NotImplementedException();
        }

        public void jabatan(string jabatan)
        {
            throw new NotImplementedException();
        }

        public void salary(int salary)
        {
            throw new NotImplementedException();
        }
    }
}
