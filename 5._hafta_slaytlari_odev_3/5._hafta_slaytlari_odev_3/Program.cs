using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._hafta_slaytlari_odev_3
{
    class KrediHesabi
    {
        public ulong HesapNo;
    }
    class Program
    {
        static void Main(string[] args)
        {
            KrediHesabi hesap1 = new KrediHesabi();
            KrediHesabi hesap2 = new KrediHesabi();
            hesap1.HesapNo = 3456;
            hesap2.HesapNo = 1111;
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap2.HesapNo);


            Console.ReadKey();


            //çıktısı sırasıyla;
            //3456
            //1111
        }
    }
}
