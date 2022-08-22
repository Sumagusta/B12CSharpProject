using System;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch case
            int bulan = 2;
            switch (bulan)
            {
                case 1:
                    Console.WriteLine("Januari");
                    break;
                case 2:
                    Console.WriteLine("Februari");
                    break;
                default:
                    Console.WriteLine("bulan tidak sesuai");
                    break;
            }
            Console.WriteLine("\n--case string--\n");
            string bulanString = "Maret";
            switch (bulanString)
            {
                case "Januari":
                    Console.WriteLine("Bulan Januari");
                    break;
                case "Februari":
                    Console.WriteLine("Februari");
                    break; 
                case "Maret":
                    for(int i=0; i< 5; i++)
                    {
                        Console.WriteLine("Maret");
                    }
                    break;
                default:
                    Console.WriteLine("bulan tidak sesuai");
                    break;
            }

            Console.WriteLine("\n--if-else--\n");

            // if-else
            // negasi : &&, ||

            int usia = 6;
            if (usia < 1)
            {
                Console.WriteLine("Baru dalam kandungan / baru lahir");
            } else if (usia < 5 && usia >= 3) // && semua kondisinya harus true
            {
                Console.WriteLine("TK");
            }else if (usia > 5 && usia != 6 || usia >= 5 && usia != 6 && usia < 7) // || salah satu kondisi true maka semua dianggap true
            {
                Console.WriteLine("TK Nol Besar");
            }
            else
            {
                Console.WriteLine("Tidak berusia");
            }
        }
    }
}
