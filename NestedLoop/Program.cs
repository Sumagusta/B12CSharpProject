using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inputkan baris : ");
            int baris = int.Parse(Console.ReadLine());

            Console.Write("Inputkan kolom : ");
            int kolom = int.Parse(Console.ReadLine());

            for(int i=0; i<baris; i++)
            {
                Console.WriteLine("baris {0}", i);
                for(int j = 0; j<kolom; j++)
                {
                    Console.WriteLine("\tkolom {0}", j);
                }
            }
        }
    }
}
