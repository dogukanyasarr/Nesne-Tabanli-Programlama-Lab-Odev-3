using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._hafta_Lab_Uygulama_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayilar = new Random();
            Console.WriteLine("sayı miktarını giriniz:");
            int giris = Convert.ToInt32(Console.ReadLine());
            int sayi;
            
            int[] pozitif = new int[giris];
            int[] negatif = new int[giris];
            int[] hepsi = new int[giris];

            for(int i=0; i<giris; i++)
            {
                sayi = sayilar.Next(-100, 100);
                if (sayi < 0)
                {
                    negatif[i] = sayi;
                }
                else if (sayi > 0)
                {
                    pozitif[i] = sayi;
                }
                else
                {
                }

                hepsi[i] = sayi;

            }

            Console.WriteLine("\ntüm sayılar:");
            foreach(int i in hepsi)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("\npozitif sayilar");
            foreach(int x in pozitif)
            {
                if(x != 0)
                {
                    Console.Write(x + ", ");
                }
                else
                {
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\nnegatif sayilar");
            foreach(int y in negatif)
            {
                if (y != 0)
                {
                    Console.Write(y + ", ");
                }
                else
                {
                }
            }

            Console.ReadKey();
        }
    }
}
