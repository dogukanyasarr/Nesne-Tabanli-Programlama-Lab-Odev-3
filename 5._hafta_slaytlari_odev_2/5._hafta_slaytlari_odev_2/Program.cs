using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._hafta_slaytlari_odev_2
{
    class Ogrenci
    {
        public ulong OgrenciNo = 215541027;
        public string Ad = "Dogukan";
        public string Soyad = "Yasar";
        public string Bolum = "Yazilim Muhendisligi";
        public byte Sinif = 2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine(ogr.OgrenciNo);
            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.Soyad);
            Console.WriteLine(ogr.Bolum);
            Console.WriteLine(ogr.Sinif);


            Console.ReadLine();


            //  çıktısı;
            //215541027
            //Dogukan
            //Yasar
            //Yazilim Muhendisligi
            //2



        }
    }
}
