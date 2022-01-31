using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma3
{
    class Program
    {
        static void Main()
        {
            //Soru6();

            //Soru7();

            //Soru8();
        }
        private static void Soru8()

        {

            int t = 1;

            int f = 1;

            Console.WriteLine("x i giriniz");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n yi giriniz");

            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i < n)

            {

                f = f * i;

                t = (int)((Math.Pow(x, i) / f) + t);

            }

            Console.WriteLine(t);



        }



        private static void Soru7()

        {

            int sayi = 1;

            int adet = 0;

            sayi++;

            while (sayi < 100)

            {



                if (sayi % 2 == 0)

                {

                    sayi++;

                }

                if (sayi % 3 == 0)

                {

                    sayi++;

                }

                if (sayi % 5 == 0)

                {

                    sayi++;

                }

                if (sayi % 7 == 0)

                {

                    sayi++;

                }

                adet++;

            }

            Console.WriteLine(adet);

        }



        private static void Soru6()

        {

            Console.WriteLine("İkilik sisteme dönüştürmek istediğiniz sayiyi giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            int top = 0;

            Console.WriteLine(sayi);

            while (sayi >= 2)

            {

                top = (int)(top + ((sayi % 2) * (Math.Pow(10, i))));

                sayi = sayi / 2;

                i++;

            }

            top = (int)(top + (sayi * (Math.Pow(10, i))));

            Console.WriteLine(top);

        }
    }
}
