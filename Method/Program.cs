using Oop.constructor;
using Oop.Core;
using Oop.exceptionhandling;
using Oop.generic;
using Oop.Inheritance.extend;
using Oop.Inheritance.impl;
using Oop.Inheritance.impl2;
using Oop.Inheritance.listabal;
using Oop.methodArgs.output;
using Oop.polymorphism.overriding;
using Oop.Static;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Oop
{
    class Program : Calculator
    {
                
        static void Main(string[] args)
        {

            // instance
            Calculator cal = new Calculator();
            cal.pengurangan();

            Program pro = new Program();
            pro.perkalian();
            //perkalian();

            Console.WriteLine("Panggil Sekolahan\n");
            Sekolahan sekolah = new Sekolahan();
            sekolah.panggilBocil();

            Console.WriteLine("Biodata Karyawan");

            Admin bio = new Admin();
            bio.biodataKaryawan();
            bio.divisiBio();

            Console.WriteLine(Movie.tahun);
            Movie.runMovie();

            EmployeePertama emp = new EmployeePertama();
            emp.biodata();
            emp.jabatan("Ketua Divisi");

            IEmployeeContract emp2 = new EmployeePertama();
            emp2.biodata();
            emp2.jabatan("Ketua Divisi");

            Anak anak = new Anak();
            anak.terimaWarisan();

            new Cucu().cucuTerimaWarisan();

            // implements output
            Console.WriteLine("----------------implements--------------------");
            new AnakPertama().warisan1();
            new AnakKedua().warisan1();
            new AnakKetiga().warisan1();

            Console.WriteLine("----------------List Abal--------------------");
            IListAbal iListAbal = new ListAbal();
            iListAbal.fungsi2();
            
            ListAbal ListAbal = new ListAbal();
            ListAbal.fungsiTambahan();
            ListAbal.runAllFunc();

            MethodOutput mo = new MethodOutput();
            //mo.rataRataNilai();

            Console.WriteLine("--Overriding--");
            Animal klw = new Kelelawar();
            klw.suara();

            // generic
            Console.WriteLine("Generic Class");
            Biodata<String> nama = new Biodata<string>("Robert");
            Biodata<String> alamat = new Biodata<string>("Jakarta Selatan");
            Biodata<int> usia = new Biodata<int>(7);

            Console.WriteLine("Nama : {0}\nAlamat : {1}\nUsia : {2}\n", nama.getBiodata(), alamat.getBiodata(), usia.getBiodata());

            IList<string> a = new List<string>();
            IList<int> b = new List<int>();
            a.Add("a");
            b.Add(1);

            // generic method
            GenericMethod print = new GenericMethod();
            Console.WriteLine(print.nominal<string>("Lima Ratus"));
            Console.WriteLine(print.nominal<int>(500));

            // try catch

            TryCatch tryObj = new TryCatch();
            int angka1 = 10;
            int angka2 = 1;
            int[] arr = new int[2];
            //Console.WriteLine(tryObj.aritmatika(10, 0));
            try
            {
                
                /*arr[0] = 2;
                arr[1] = 3;
                arr[2] = 4;*/

                Console.WriteLine(tryObj.aritmatika(angka1, angka2));

                try
                {
                    arr[0] = 2;
                    arr[1] = 3;
                    arr[2] = 4;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Index Array tidak boleh > {0}, error : {1}", arr.Length, e.Message);
                }
                finally
                {
                    Console.WriteLine("Handle Nested 1 Exception");
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Pembagi {0} tidak boleh bernilai 0, error : {1}", angka2, e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Array tidak boleh > {0}, error : {1}", arr.Length, e.Message);
            }
            finally
            {
                Console.WriteLine("Syntax ini sudah dihandle");
            }

            Console.WriteLine("Fungsi yang dijalankan setelah aritmatika ..");

            ThrowException te = new ThrowException();
            //te.bioskop();

            EmployeeKedua ep = new EmployeeKedua();
            ep.durasi(2022);

        }
    }
}
