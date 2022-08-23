using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.methodArgs.output
{
    class MethodOutput
    {
        // void -> kosong / hampa : suatu method yang tidak memiliki output
        // method dengan output dataType -> suatu method yang memiliki output atau nilai pengembalian -> ciri2 : RETURN
        // 

        public int nilaiAlpro(int nilai)
        {
            return nilai;
        }

        public int nilaiPBO(int nilai)
        {
            return nilai;
        }

        public void rataRataNilai()
        {
            bool iterate = true;

            while (iterate) { 
                Console.Write("Masukkan Nilai Alpro : ");
                int nilaiAlproVal = int.Parse(Console.ReadLine());
            
                Console.Write("Masukkan Nilai PBO : ");
                int nilaiPBOVal = int.Parse(Console.ReadLine());

                int result = (nilaiAlpro(nilaiAlproVal) + nilaiPBO(nilaiPBOVal)) / 2;
                Console.WriteLine(result);

                Console.WriteLine("close? n/y");
                string jawab = Console.ReadLine();

                if (jawab.ToLower().Equals("y"))
                {
                    iterate = false;
                }
            }
        }
    }
}
