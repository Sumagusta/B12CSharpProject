using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.constructor
{
    public class Bocil
    {
        // constructor : 
        /*
            1. nama method sama dengan class
            2. deklarasi bisa tanpa menggunakan void/type lain
            3. setiap yang di deklarasikan di contructor akan dibawa oleh class kemanapun dia menjadi object.
         */

        // constructor
        
        public Bocil()
        {
            // empity
        }

        public Bocil(string bekal)
        {
            Console.WriteLine("Bekal Makanan {0}", bekal);
        }

        public void status()
        {
            Console.WriteLine("Status : Jomblo");
        }
    }
}
