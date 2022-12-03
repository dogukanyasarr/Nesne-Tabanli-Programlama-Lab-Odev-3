using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._hafta_slaytlari_odev_9
{
    public class Hayvan
    {
        protected String a = "Hayvan.a";
        String b = "Hayvan.b"; //friendly
        private String c = "Hayvan.c";
        public String d = "Hayvan.d";
    }

    public class Kedi : Hayvan
    {

        public Kedi()
        {

            Console.WriteLine("Kedi olusturuluyor");
            Console.WriteLine(a);
            //Console.WriteLine(b); 
            //Console.WriteLine(c);  b ve c erişilemez
            Console.WriteLine(d);
        }
    }

    class deneme
    {
        public static void Main(string[] args)
        {
            Kedi k = new Kedi();
            Console.ReadKey();
        }
    }
}
//programın çıktısı
//Kedi olusturuluyor
//Hayvan.a
//Hayvan.d

