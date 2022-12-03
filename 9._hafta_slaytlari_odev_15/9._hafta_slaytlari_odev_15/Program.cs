using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._hafta_slaytlari_odev_15
{
    interface IArayuz
    {
        int Metot1();
        void Metot2();
    }
    class Sinif : IArayuz
    {
        int IArayuz.Metot1()
        {
            Console.WriteLine("Metot1");
            return 0;
        }
        public void Metot2()
        {
            Console.WriteLine("Metot2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sinif s = new Sinif();
            IArayuz a;
            a = s;
            a.Metot1();
            Console.ReadKey();
        }
    }
}

        //çıktısı
        //    Metot1
