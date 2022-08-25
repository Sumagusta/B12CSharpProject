using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.recursive
{
    class Recursive1
    {
        public static int menghitung(int n)
        {
            Console.WriteLine(n);

            if(n == 1 || n == 0)
            {
                return 0;
            }

            return menghitung(n-1);
        }

        public static void running()
        {
            for (int i = 100000; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // menghitung(100000);
        }
    }
}
