using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    public class Calculator
    {

        // modifier : private, public, protected

        // encapsulation : pembungkusan suatu deklarasi didalam method
        private void pertambahan()
        {
            int a = 10, b = 15, result;
            result = a + b;
            Console.WriteLine(result);
        }
        
        public void pengurangan()
        {
            int a = 10, b = 15, result;
            result = a - b;
            Console.WriteLine(result);
        }
        
        protected void perkalian()
        {
            int a = 10, b = 15, result;
            result = a * b;
            Console.WriteLine("{0} x {1} = {2}", a, b, result);
        }

        public void compilation()
        {
            pertambahan();
            perkalian();
        }
    }
}
