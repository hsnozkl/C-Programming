using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05
{
    class Program
    {
        static void Main(string[] args)
        {
            //InLineif();
            Ornek();
            //Kullanıcıdan ayrı ayrı 2sayı iste. 1. satı 2. sayı büyük/küçük/eşit.
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("1. sayıyı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string cevap = sayi1 > sayi2 ? "1. sayı 2. sayıdan büyük." : sayi1 == sayi2 ? "1. sayı ve 2. sayı eşit." : "1. sayı 2. sayıdan küçük." ;
            Console.WriteLine(cevap);
        }

        /*private static void InLineif()
        {
            int sayi = 9;
            bool a = 9 % 3 == 0 ? true : false;
            string kullanici_sehir = Console.ReadLine();
            string sehir = kullanici_sehir == "Istanbul" ? "34" : kullanici_sehir == "istanbul" ? "34" : "0";
            Console.WriteLine(sehir);
        }*/
    }
}
