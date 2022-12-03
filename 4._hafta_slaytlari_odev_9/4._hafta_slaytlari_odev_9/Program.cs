using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._hafta_slaytlari_odev_9
{
    class metorlar_5a
    {
        static void DegerTipAktarim(int Sayi)
        {
            Sayi = 30;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x);

            DegerTipAktarim(x);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}

// x x değişkeninin değerini metot içinde değiştirmek değerini değerini değiştirmemiştir.
// Çünkü x değer olarak metoda aktarılmıştır.

// program çıktısı da her ikisi için de 100 olur.