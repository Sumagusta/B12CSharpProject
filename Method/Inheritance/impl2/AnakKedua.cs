﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance.impl2
{
    class AnakKedua : IOrangTua
    {
        public void warisan1()
        {
            Console.WriteLine("Emas Antam 1Kg");
        }

        public void warisan2()
        {
            throw new NotImplementedException();
        }

        public void warisan3()
        {
            throw new NotImplementedException();
        }
    }
}
