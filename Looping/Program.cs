using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            int i = 5;

            while (i < 5) // loop dengan iterasi yang tidak pasti
            {
                Console.WriteLine("Selamat Siang -> while");

            }
            Console.WriteLine();
            // do-while
            int i2 = 0;
            do
            {
                Console.WriteLine("Selamat Siang -> do - while");
                
                i2++;
            } while (i2<5);

            for(int x = 0; x<5; x++) // loop dengan iterasi yang pasti
            {
                Console.WriteLine("Selamat Siang -> for");
            }
        }
    }
}
