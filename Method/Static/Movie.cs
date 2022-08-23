using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Static
{
    class Movie
    {
        // static : 1 Memory 
        public string judul { get; set; }
        public string rating { get; set; }
        public static int tahun { get; set; }
        public IList<string> casting { get; set; }
        
            public static void runMovie()
            {
                var movie1 = new Movie();
                var movie2 = new Movie();
                movie1.judul = "Ultraman";
                movie2.judul = "Bajaj Bajuri";
                Movie.tahun = 1000;

                Console.WriteLine(movie1.judul);
                Console.WriteLine(movie2.judul);



        
        }
        
    }
}
