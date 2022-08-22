using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Type 
            // Value Data Type

            // sbyte & byte

            sbyte byteStore = 125;
            Console.WriteLine("sbyte max value : "+sbyte.MaxValue);
            //byte

            //short
            short shortType = 20000;
            Console.WriteLine("data yang dipakai shortType {0} dan max data {1}, batas bawah adalah : {2}", shortType, short.MaxValue, short.MinValue);

            ushort uShortType = 40000;
            Console.WriteLine("data yang dipakai uShortType {0} dan max data {1}, batas bawah adalah : {2}", uShortType.GetType(), ushort.MaxValue, ushort.MinValue);

            int integerType = 12000;
            Console.WriteLine("data yang dipakai integerType {0} dan max data {1}, batas bawah adalah : {2}", integerType, int.MaxValue, int.MinValue);

            long longType = 4323433L;


            // Floating point
            float floatType = 3.40282347E+38F;

            double doubleType = 792281.5;

            decimal decimalType = 792281.5M;

            //char
            char karakter = 'A';

            // boolean
            bool booleanType = true;


            // Reference Data Type

            // var
            var varType = 400;
            int kali = 4;
            Console.WriteLine(varType.GetType());

            //object
            object data = 4000000;

            //string
            string dataString = "ini data string";
            Console.WriteLine(dataString.IndexOf('d'));

            // substring
            Console.WriteLine(dataString.Substring(4));
            Console.WriteLine(dataString.Substring(4, 7));// startFrom, panjangData

            // konversi
            string angkaString = "400";
            Console.WriteLine(int.Parse(angkaString) + 100);

            // aritmatic data type
            int a = 10;
            double b = 10.5;
            var hasil = a + b;
            Console.WriteLine(hasil);

            int? a2 = 10;
            int result = a2 ?? 1;

            Console.WriteLine("result : "+result);
        }
    }
}
