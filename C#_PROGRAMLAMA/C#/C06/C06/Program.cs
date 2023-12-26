using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ornek();
            //vizenin %40 ını finalin %60 ını alın . final ve ze toplamı 50 den az ise veya vize 0 ise kaldın yazdır. 
            Ornek2();
            //girilen sayı tek ise karesini çift ise kübünü alın.
            Console.ReadLine();
        }

        private static void Ornek2()
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            double sayi = Convert.ToDouble(Console.ReadLine());
            if(sayi % 2 == 0)
            {
                Console.WriteLine(sayi * sayi * sayi);
            }
            else
            {
                Console.WriteLine(sayi * sayi);
            }
        }

        /*private static void Ornek()
        {
            Console.WriteLine("Vize notunuzu giriniz.");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz.");
            double final = Convert.ToDouble(Console.ReadLine());
            vize = vize * 40 / 100;
            final = final * 60 / 100;
            if((vize + final) < 50 || vize == 0)
            {
                Console.WriteLine("Dersten kaldınız.");
            }
            else
            {
                Console.WriteLine("Tebrikler dersten geçtiniz.");
            }
        }*/
    }
}
