using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.polymorphism.overloading
{
    class Calculator
    {
        // Overloading = methodnya sama dengan args/param yang berbeda dalam satu class yang sama
        
         
        ///
        /// <summary>
        ///     Overloading hitung dengan pertambahan (a+b)
        /// </summary>
        public int hitung(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("{0} + {1}",a,b);
            return result;
        }

        /// <summary>
        ///     Overloading hitung dengan pertambahan dan kali (a+b)*c
        /// </summary>
        public int hitung(int a, int b, int c)
        {
            int result = (a + b)*c;
            Console.WriteLine("{0} + {1} * {3}",a,b, c);
            return result;
        }

        /// <summary>
        ///     Overloading hitung dengan pertambahan double (a+b)
        /// </summary>
        public double hitung(int a, double b)
        {
            double result = a + b;
            Console.WriteLine("{0} + {1}", a, b);
            return result;
        }
    }
}
