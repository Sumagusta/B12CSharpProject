using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.exceptionhandling
{
    class ThrowException
    {
        public int siswa(int age)
        {
            return age;
        }

        public void bioskop()
        {
            if (siswa(19) < 18)
            {
                throw new Exception(); // ciptakan error dengan return ke exception
            }
            Console.WriteLine("Kamu bisa nonton film");
        }
    }
}
