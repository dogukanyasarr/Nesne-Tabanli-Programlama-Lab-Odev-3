using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._hafta_slaytlari_odev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] dizi = new int[3][];

            dizi[0] = new int[] { 1, 2 };
            dizi[1] = new int[] { 3, 4, 5, 6, 7 };
            dizi[2] = new int[] { 8, 9, 0 };

            foreach(int[] boyut in dizi)
            {
                foreach(int eleman in boyut)
                {
                    Console.Write("{0,3}" , eleman);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

//program çıktısı sırasıyla
//1  2
//3  4  5  6  7  
//8  9  0
