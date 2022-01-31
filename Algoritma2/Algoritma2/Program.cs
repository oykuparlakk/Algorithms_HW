using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma2
{
    class Program
    {
        static void Main()
        {
            //Soru1

            //Console.WriteLine("Sirasiyla ussunu almak istediğiniz sayiyi ve derecesini giriniz:");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int us = Convert.ToInt32(Console.ReadLine());

            //Power(sayi, us);



            //Soru2

            int[] array = { 5, 6, 7, 4, 2, 1, 54, 88, 98, 65 };

            //soru 3: dizinin ilk ve son elemanlarını takas edin

            //int uzunluk = array.Length-1;

            //int son_temp = array[0];

            //array[0] = array[uzunluk];

            //array[uzunluk] = son_temp;

            //Console.WriteLine("Takas edilmiş halde ilk deger ve sonuncu deger:" +array[0]+" "+array[uzunluk] );

            //Soru4

            //for (int i = 0; i < array.Length; i++)

            //{

            //    Console.Write(array[i] + " ");

            //}

            //Console.WriteLine("\n" + "Sirasiyla yerlerini degistirmek istediginiz indisleri giriniz:" + "\n");

            //int indis1 = Convert.ToInt32(Console.ReadLine());

            //int indis2 = Convert.ToInt32(Console.ReadLine());

            //swap(array, indis1, indis2);

            //for (int i = 0; i < array.Length; i++)

            //{

            //    Console.Write(array[i] + " ");

            //}

            BubbleSort(array);
        }
        private static void BubbleSort(int[] array)

        {

            for (int i = 0; i < array.Length - 1; i++)

            {



                for (int j = 1; j < array.Length - i; j++)

                {



                    if (array[j] < array[j - 1])

                    {



                        swap(array, j - 1, j);

                    }

                }

            }

            for (int i = 0; i < array.Length; i++)

            {

                Console.Write(array[i] + " ");

            }

        }



        private static void swap(int[] array, int indis1, int indis2)

        {



            int temp = array[indis1];

            array[indis1] = array[indis2];

            array[indis2] = temp;

            //for (int i = 0; i < array.Length; i++)

            //{

            //    Console.Write(array[i] + " ");

            //}





        }

        private static void Power(int sayi, int us)

        {

            int temp = sayi;

            for (int i = 1; i < us; i++)

            {

                sayi *= temp;



            }

            Console.WriteLine("Sonuc:" + sayi);

        }
    }
}

