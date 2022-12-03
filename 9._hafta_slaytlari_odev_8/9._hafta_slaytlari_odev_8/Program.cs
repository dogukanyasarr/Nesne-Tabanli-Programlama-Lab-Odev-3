using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._hafta_slaytlari_odev_8
{
    class Kedi
    {
        protected int ayakSayisi = 4;

        public void yakalaAv()
        {
            Console.WriteLine("Kedi sinifi Av yakaladi");
        }
    }

    class Kaplan : Kedi
    {
        public Kaplan()
        {
            Console.WriteLine("Ayak Sayisi= " + ayakSayisi);
        }
    }

    class deneme
    {
        public static void Main(string[] args)
        {
            Kedi kd = new Kedi();
            kd.yakalaAv();
            Kaplan kp = new Kaplan();

            Console.ReadKey();

        }
    }
}

//programın çıktısı
//Kedi sinifi Av yakaladi
//Ayak Sayisi = 4
