using Oop.constructor;
using Oop.Core;
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

            // generic interface

        }
    }
}
