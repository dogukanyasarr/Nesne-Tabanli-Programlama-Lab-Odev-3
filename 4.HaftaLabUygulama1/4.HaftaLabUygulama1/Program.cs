using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaLabUygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Goster(sayilar);
            TersGoster(sayilar);
            SoruGoster(sayilar);
            Console.ReadKey();

        }
        public static void Goster(int [] dizi)
        {
            for(int i =0; i<10; i++)
            {

                Console.Write("dizinin " + i + ". " + "elemanı: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static void TersGoster(int [] dizi)
        {
            for(int i =9; i>=0; i--)
            {
                Console.WriteLine("dizinin " + i + ". " + "elemanı: " + dizi[i]);
            }
            Console.WriteLine();
        }

        static void SoruGoster(int [] dizi)
        {
            
            Console.WriteLine("görmek istediğiniz diziyi yazınız: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("dizinin " + sayi + ". " + "eleman: " + dizi[sayi]);
        }
    }
}
