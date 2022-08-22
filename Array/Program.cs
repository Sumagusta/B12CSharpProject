using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // array untuk menyimpan data lebih dari satu namun hanya di satu variable yang sama

            int a = 10, b = 20, c = 30 , d = 40;

            //ARRAY 1D
            int[] arr1d = {11, 12, 14, 16, 19, 22, 55, 11};
            foreach(int item in arr1d)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            // array size
            int?[] arrSize = new int?[5];
            arrSize[0] = 20;
            arrSize[1] = 30;
            arrSize[2] = 10;
            arrSize[3] = 230;

            /*foreach (int item in arrSize)
            {
                Console.WriteLine(item);
            }*/

            Console.WriteLine("-------------------------------------");
           
            // string
            string[] arrString = new string[3];
            arrString[0] = "mangga";
            arrString[1] = "semangka";
            foreach (string item in arrString)
            {
                Console.WriteLine(item);
            }

            // array 2D
            int[,] arr2D = new int[3,2]; // [baris] | [kolom] 

            arr2D[0,0] = 20;
            arr2D[0,1] = 10;
            
            arr2D[1,0] = 20;
            arr2D[1,1] = 10;

            foreach(int item in arr2D)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("For Basic");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    if (i == 2)
                    {
                        arr2D[i, j] = 30;
                    }
                    Console.WriteLine(arr2D[i, j]);
                }
            }

            int[,] arr2DBasic = { 
                                    { 0,0},{ 0,1} 
                                };

            


        }
    }
}
