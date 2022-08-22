using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> keranjangBuah = new List<String>(); // seperti array, tapi lebih banyak fungsi yang bisa kita gunakan / lebih bisa dimanipulasi
            keranjangBuah.Add("Anggur");
            keranjangBuah.Add("Manggis");
            keranjangBuah.Add("Semangka");

            foreach(string buah in keranjangBuah)
            {
                Console.WriteLine(keranjangBuah.IndexOf(buah) +" - "+ buah);
            }

            Console.WriteLine("Hapus Manggis");
            keranjangBuah.Remove("Manggis");

            foreach (string buah in keranjangBuah)
            {
                Console.WriteLine(keranjangBuah.IndexOf(buah) + " - " + buah);
            }

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            List<int> reverse = Enumerable.Reverse(list).ToList();

            Console.WriteLine(String.Join(',', reverse));
            IList<String> dataIList = new List<String>();

            Console.WriteLine("---Collection---");
            ICollection<int> collect = new List<int>();
            for(int i = 0; i< 5; i++)
            {
                collect.Add(i);
            }

            foreach(int item in collect)
            {
                Console.WriteLine(item);
            }

        }
    }
}
