using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._hafta_slaytlari_odev_1
{
    class A
    {
        public int a;
        public A()
        {
            a = 1;
        }
    }

    class T : A
    {
        public int a;
        public T()
        {
            a = 2;
        }
    }

    class Program
    {
        static void Main()
        {
            T t = new T();
            Console.WriteLine(t.a);
            Console.ReadKey();
        }

    }
}

//program çıktısı
//1
