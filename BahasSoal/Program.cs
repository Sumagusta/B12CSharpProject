using System;

namespace BahasSoal
{
    class Program
    {

        int data;

        static int HandleTask()
        {

            //That code will already throw an FormatException.If you mean you want to catch it, you could write:

            string firstName;
            string ageText;
            int age;
            int result = 0;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageText = Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
                Console.WriteLine(
                    $"Hi { firstName }! You are { age * 12 } months old.");
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    $"The age entered, { ageText }, is not valid.");
                result = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
                result = 1;
            }
            finally
            {
                Console.WriteLine($"Goodbye { firstName }");
            }

            return result;
        }
        static void LoopTaskNo5()
        {
            string inputBaris = Console.ReadLine();
            int baris;
            try // exception handling
            {
                baris = int.Parse(inputBaris);
                Console.WriteLine(baris);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} bukan integer", inputBaris);
            }
            
            Console.WriteLine("Next Line ...");
            
        }

        static void taskWeek1()
        {
            string input;
            string nama = "";

            do 
            {
                Console.WriteLine(@"
1. Masukkan Nama
2. Tampilkan Nama
3. Exit
");
                Console.Write("Masukkan pilihan : ");
                input = Console.ReadLine();

                if (input.Equals("1"))
                {
                    Console.Write("Input nama : ");
                    nama = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Berhasil input, nama terbaru adalah : {0}", nama);
                }else if (input.Equals("2"))
                {
                    Console.Clear();
                    Console.WriteLine("Nama terbaru adalah : {0}", nama);
                }
            } while (!input.Equals("3"));
        }

        static void testConditionWhile()
        {
            string input = "";
            int saldo=0;
            do
            {
                saldo += 1000;
                Console.WriteLine("Saldo terakhir : {0}", saldo);

                Console.WriteLine("Lanjutkan program? N/Y");
                input = Console.ReadLine();
            } while (!input.ToLower().Equals("n"));
        }

        static void deret()
        {
            Console.Write("Ukuran Deret :");
            int ukuranDeret = int.Parse(Console.ReadLine());

            int angkaAwal = 2;
            while (ukuranDeret>0)
            {
                for(int i = 0; i<angkaAwal-1; i++)
                {
                    Console.Write(angkaAwal);
                    ukuranDeret--;
                }
                angkaAwal += 2;
            }
        }
        static void Main(string[] args)
        {
            //LoopTaskNo5();
            //HandleTask();
            //taskWeek1();
            //testConditionWhile();
            //deret();
            RecursiveTask.running();
        }
    }
}
