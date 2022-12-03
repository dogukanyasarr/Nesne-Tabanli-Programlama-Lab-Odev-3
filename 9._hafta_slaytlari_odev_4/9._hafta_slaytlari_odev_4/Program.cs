using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._hafta_slaytlari_odev_4
{
    class oto
    {
        protected double boy = 5;
        protected double agirlik = 800;
        protected string renk = "Sara";
        public void goster()
        {
            Console.WriteLine("Boy=" + boy);
            Console.WriteLine("Agirlike" + agirlik);
            Console.WriteLine("Renk=" + renk);
        }

    }

    class model1 : oto
    {
        public string tur;
        public int silindir_sayisi;
        public int subap_sayisi;
        public int tork;
        public int guc;

        public void ozellikyaz()
        {
            Console.WriteLine("Tür = " + tur);
            Console.WriteLine("Boy = " + boy);
            Console.WriteLine("Ağırlık = " + agirlik);
            Console.WriteLine("Renk = " + renk);
            Console.WriteLine("Silindir sayısı = " + silindir_sayisi);
            Console.WriteLine("Subap sayısı = " + subap_sayisi);
            Console.WriteLine("Tork = " + tork);
            Console.WriteLine("Güç = " + guc);
        }

    }

    class model2 : oto
    {
        public double model2_boy
        {
            get { return boy; }
            set { boy = value; }
        }

        public double model2_agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }

        public string model2_renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public string tur = "Hatchback";
        public int silindir_sayisi = 8;
        public int subap_sayisi = 16;
        public int tork = 300;
        public int guc = 210;

        public void ozellikyaz()
        {
            Console.WriteLine("Turs" + tur);
            Console.WriteLine("Boy=" + model2_boy);
            Console.WriteLine("Agirlake" + model2_agirlik);
            Console.WriteLine("Renk=" + model2_renk);
            Console.WriteLine("Silindir Sayisi=" + silindir_sayisi);
            Console.WriteLine("Subap Say:si=" + subap_sayisi);
            Console.WriteLine("Tork=" + tork);
            Console.WriteLine("Güç=" + guc);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            model1 oto1 = new model1();
            model2 oto2 = new model2();
            oto1.tur = "Sedan";
            oto1.silindir_sayisi = 4;
            oto1.subap_sayisi = 8;
            oto1.guc = 75;
            oto1.tork = 100;
            oto1.ozellikyaz();
            Console.WriteLine("**");
            oto2.model2_boy = 6;
            oto2.model2_agirlik = 900;
            oto2.model2_renk = "Kirmiz1";
            oto2.ozellikyaz();
            Console.WriteLine("**");
            oto2.goster();
            Console.WriteLine("*");
            oto1.goster();
            Console.ReadLine();

        }
    }
}

//programın çıktısı
//Tür = Sedan
//Boy = 5
//Ağırlık = 800
//Renk = Sara
//Silindir sayısı = 4
//Subap sayısı = 8
//Tork = 100
//Güç = 75
//**
//TursHatchback
//Boy=6
//Agirlake900
//Renk = Kirmiz1
//Silindir Sayisi = 8
//Subap Say:si=16
//Tork=300
//Güç=210
//**
//Boy = 6
//Agirlike900
//Renk = Kirmiz1
//*
//Boy = 5
//Agirlike800
//Renk = Sara

