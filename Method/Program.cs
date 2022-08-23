using Oop.constructor;
using Oop.Core;
using Oop.Inheritance.impl;
using Oop.Static;
using System;

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
        }
    }
}
