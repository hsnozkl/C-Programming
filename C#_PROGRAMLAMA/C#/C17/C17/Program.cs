using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C17
{
    class Program
    {
        static void Main(string[] args)
        {
            //For_Dongusu();
            //For_Ornek();
            //WhileDongusu();
            //DoWhile();
            //DoWhile_Ornek();
            //ForeachDongusu();
            //ForeachOrnek();
            //Ornek();
            //Ornek1();
            Ornek2();
            Console.ReadLine();
        }

        private static void Ornek2()
        {
            Console.WriteLine("Lütfen bir sayi giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = sayi; i > 0; i--)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.WriteLine("Faktoriyel değeri " + faktoriyel);
        }

        /*private static void Ornek1()
        {
            string tlf = "0532 1234567";
            for (int i = 0; i < tlf.Length; i++)
            {
                if(i == 4 || i == 7 || i == 9)
                {
                    Console.Write(" ");
                }
                Console.Write(tlf[i]);
            }
            string tlf1 = "05321234567";
            int i1 = 0;
            foreach (var item in tlf1)
            {
                if (i1 == 4 || i1 == 7 || i1 == 9)
                {
                    Console.Write(" ");
                }
                Console.Write(item);
                i1++;
            }
        }*/

        /*private static void Ornek()
        {
            int[] sayidizi = { 19, 45, -247, 212, -134, 319, -78 };
            int kp = int.MaxValue;
            int bn = int.MinValue;
            foreach (var item in sayidizi)
            {
                if(item > 0 && item < kp)
                {
                    kp = item;
                }
                else if (item < 0 && item > bn)
                {
                    bn = item;
                }
            }
            Console.WriteLine("En büyük negatif sayi: " + bn + "\nEn küçük pozitif sayi: " + kp);
        }*/

        /*private static void ForeachOrnek()
        {
            int[] sayilar = { 5, 9, 15, 17 };
            foreach (var item in sayilar)
            {
                Console.WriteLine((item - 1) * 3);
            }
        }*/

        /*private static void ForeachDongusu()
        {
            //Dolaşmak istediğimiz döngüyü bunun içine yazıyoruz.
            string[] ulkeler = { "Türkiye", "Almanya", "Fransa" };
            foreach (var item in ulkeler) //item : dizinin elemanları. collection : dizimin ismi.
            {
                Console.WriteLine(item);
            }
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }*/

        /*private static void DoWhile_Ornek()
        {
            int a = 123;
            do
            {
                Console.WriteLine("Lütfen şifreyi giriniz.");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 123);
            Console.WriteLine("Bravo");
        }*/

        /*private static void DoWhile()
        {
            int sayi = 0;
            do
            {
                Console.WriteLine("Lutfen bir sayi giriniz.");
                int sayiyeni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
                sayi++;
            } while (sayi < 5);
        }*/

        /*private static void WhileDongusu()
        {
            int sayi = 0;
            while(sayi < 5)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
        }*/

        /*private static void For_Ornek()
        {
            string[] isim = { "Can", "Osman", "Tuğba", "Cansu", "Meral" };
            for (int i = 0; i < isim.Length; i++)
            {
                Console.Write(isim[i]+"\t");
            }
        }

        private static void For_Dongusu()
        {
            //Belli sayılar arasında otamatik dönmek için kullanılır.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //burdan devam eder.
        }*/
    }
}
