﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._hafta_slaytlari_odev_7
{
    class A
    {
        public int a;

        public A(int a)
        {
            this.a = a;
            Console.WriteLine("A yapacısı çalıştı\n");
        }

    }

    class B : A
    {
        public int b;
        public B(int a, int b) : base(a)
        {
            this.b = b;
            Console.WriteLine("B yapacısı çalıştı\n");
        }
    }

    class C : B
    {
        public int c;
        public C(int a, int b, int c) : base(a, b)
        {
            this.c = c;
            Console.WriteLine("C sanifinin yapıcısı çağrıldı\n");
        }

    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------");
            Console.WriteLine("C Nesnesi");
            C c = new C(2, 3, 4);
            Console.WriteLine("a = " + c.a);
            Console.WriteLine("b = " + c.b);
            Console.WriteLine("c = " + c.c + "\n");

            Console.WriteLine("----------");
            Console.WriteLine("B Nesnesi");
            B b = new B(5, 6);
            Console.WriteLine("a=" + b.a);
            Console.WriteLine("b=" + b.b + "\n");

            Console.WriteLine("----------");
            Console.WriteLine("A Nesnesi");
            A a = new A(7);
            Console.WriteLine("a = " + a.a + "\n");
            Console.ReadKey();
        }
    }
}

//programın çıktısı
//----------
//C Nesnesi
//A yapacısı çalıştı

//B yapacısı çalıştı

//C sanifinin yapıcısı çağrıldı

//a = 2
//b = 3
//c = 4

//----------
//B Nesnesi
//A yapacısı çalıştı

//B yapacısı çalıştı

//a=5
//b=6

//----------
//A Nesnesi
//A yapacısı çalıştı

//a = 7
