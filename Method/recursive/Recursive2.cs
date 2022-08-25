using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.recursive
{
    class Recursive2
    {
		private static int rekursifFibonachi(int ukuran, String ranting)
		{

			Console.WriteLine("Ranting ke " + ranting);
			Console.WriteLine("Fibonachi ke " + ukuran);
			Console.WriteLine();

			if (ukuran == 0 || ukuran == 1)
			{
				return ukuran;
			} // f3 = f2 + f1
			  // f2 = f1 + f0					2								1
			return rekursifFibonachi(ukuran - 1, "kiri") + rekursifFibonachi(ukuran - 2, "kanan");
		}

		public static void running()
        {
			int data = rekursifFibonachi(3, "atas");

			Console.WriteLine("nilai fibo ke " + data);
		}
	}

}
