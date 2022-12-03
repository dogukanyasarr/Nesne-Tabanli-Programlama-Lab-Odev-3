using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Hafta_Lab_Uygulama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrisA = { { 4, 2, 7 }, { 3, 9, 1 }, { 4, 7, 5 } };
            int[,] matrisB = { { 6, 1, 4 }, { 4, 3, 5 }, { 3, 6, 4 } };

            MatrisCarpım(matrisA, matrisB);
            Console.ReadLine();
        }
        static void MatrisCarpım(int[,] dizi1, int[,] dizi2)
        {
            int[,] sonuc = new int[3, 3];
            for (int k = 0; k < 3; k++)
                for (int i = 0; i < 3; i++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        sonuc[k, i] += dizi1[k, m] * dizi2[m, i];
                    }
                    
                }
            Console.WriteLine("\n----A MATRİSİ----");

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("");
                for (int b = 0; b < 3; b++)
                {
                    Console.Write(dizi1[a, b] + "\t");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\n----B MATRİSİ----");
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("");
                for(int y=0; y<3; y++)
                {
                    Console.Write(dizi2[x, y] + "\t");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\n-C MATRİSİ (SONUC)-");
            for (int p = 0; p < 3; p++)
            {
                Console.WriteLine("");
                for (int s = 0; s < 3; s++)
                {
                    Console.Write(sonuc[p, s] + "\t");

                }
            }
        }
    }
}
