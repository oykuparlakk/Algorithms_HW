using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritma1
{
    class Program
    {
        static void Main()
        {
            //Soru1();


            ////Soru 2 için değerlerin alınması
            //Console.WriteLine("1. denklemin sırasıyla kx1,ky1,r1 degerini giriniz");
            //int kx1 = Convert.ToInt32(Console.ReadLine());
            //int ky1 = Convert.ToInt32(Console.ReadLine());
            //int r1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. denklemin sırasıyla kx2,ky2,r2 degerini giriniz");
            //int kx2 = Convert.ToInt32(Console.ReadLine());
            //int ky2 = Convert.ToInt32(Console.ReadLine());
            //int r2 = Convert.ToInt32(Console.ReadLine());

            ////alinan degerlerin soru2 icin yazilan metoda gönderilmesi
            //Soru2(kx1, ky1, r1, kx2, ky2, r2);
            Soru3();
        }
        private static void Soru3()
        {
            var DecToRoman = new Dictionary<int, string>()
            {
                {1,"I"},
                {4,"IV"},
                {5,"V"},
                {9,"IX"},
                {10,"X"},
                {40,"XL"},
                {50,"L"},
                {90,"XC"},
                {100,"C"},
                {400,"CD"},
                {500,"D"},
                {900,"CM"},
                {1000,"M"},
            };
            Console.WriteLine("Romen rakamına çevirmek istediğiniz sayiyi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string romen = "";
            while (sayi != 0)
            {
                if (sayi != 0)
                {
                    int myKey = DecToRoman.Where(x => x.Key <= sayi)
                                          .OrderByDescending(x => x.Key)
                                          .First().Key;
                    sayi = sayi - myKey;
                    romen += DecToRoman[myKey];
                } 
            }
            Console.WriteLine(romen);
        }

        private static void Soru2(int kx1, int ky1, int r1, int kx2, int ky2, int r2)
        {
            //yok etme metodunda x e göre pozitiflik negatiflik bakarak mantıksal işlemleri yazdım
            if (kx1>0 && kx2>0 || kx1<0 && kx2<0)
            {
                int y = ((-kx2)*r1+(kx1)*r2)/((ky1*-kx2)+(ky2*kx1));
                int x = (r2 - (ky2 * y)) / kx2;
                Console.WriteLine("x y sırayla" + x + y);
            }
            else if (kx1<0 && kx2>0 || kx1>0 && kx2<0)
            {
                int y = ((r1 * kx2) + (r2 * kx1)) / ((ky1 * kx2) + (ky2 * kx1));
                int x = (r2 - (ky2 * y)) / kx2;
                Console.WriteLine("x y sırayla" + x + y);
            }          
        }
        private static void Soru1()
        {
            //kök bulma formülü b^2-4ac
            Console.WriteLine("Sirasiyla denklemin a b c degerlerini giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("degerler alindi...");
            //delta>0 için birbirinden farklı iki kök
            //delta=0 için bir kök (çakışık kök)
            //delta<0 gerçek kök yok
            double delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                double x1 = ((-b - Math.Sqrt(delta)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("x1 =" + x1);
                Console.WriteLine("x2 =" + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Delta=0 tek kök vardır : ");
                Console.WriteLine("x =" + x);
            }
            else
            {
                Console.Write("Gerçek Kök Yoktur");
            }
            Console.ReadKey();
        }

    }
}
