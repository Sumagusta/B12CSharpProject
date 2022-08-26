using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BahasSoal
{
    public class RecursiveTask
    {
        static Random rand = new Random();

        public static bool inputPermainan(int lompatan, int[] tangga)
        {
            return permainan(lompatan, tangga, rand.Next(2));
        }

        public static bool permainan(int lompatan, int[] tangga, int i)
        {
            if(i >= tangga.Length)
            {
                return true;
            }else if (i < 0 || tangga[i] == 1)
            {
                return false;
            }

            tangga[i] = 1;

            return permainan(lompatan, tangga, i+lompatan) ||
                   permainan(lompatan, tangga, i+1) ||
                   permainan(lompatan, tangga, i-1);
        }

        public static void running()
        {
            Console.Write("Jumlah Permainan : ");
            int q = int.Parse(Console.ReadLine());

            while(q-- > 0)
            {
                int jumlahAnakTangga = int.Parse(Console.ReadLine());
                int lompatan = int.Parse(Console.ReadLine());

                int[] tangga = new int[jumlahAnakTangga];
                for(int i=0; i<tangga.Length; i++)
                {
                    tangga[i] = rand.Next(2);
                }

                Console.WriteLine((inputPermainan(lompatan, tangga)) ? "MENANG":"KALAH");
            }
        }
    }
}
