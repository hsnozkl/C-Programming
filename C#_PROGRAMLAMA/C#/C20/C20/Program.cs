using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20
{
    class Program
    {
        static void Main(string[] args)
        {
            //RastgeleSayi();
            //RastgeleOrnek();
            TasKagitMakas();
            Console.ReadLine();
        }

        private static void TasKagitMakas()
        {
            int kazanan = 0;
            int kaybeden = 0;
            string kullanici = "";
            do
            {
                Console.WriteLine("Lüfen taş kağıt makas seçeneklerinden birini girin.");
                kullanici = Console.ReadLine();
                string[] secenek = { "tas", "kagit", "makas" };
                Random pc = new Random();
                int a = pc.Next(3);
                if(kullanici == "tas" && secenek[a]== "kagit")
                {
                    kaybeden++;
                }
                if (kullanici == "tas" && secenek[a] == "makas")
                {
                    kazanan++;
                }
                if (kullanici == "makas" && secenek[a] == "kagit")
                {
                    kazanan++;
                }
                if (kullanici == "makas" && secenek[a] == "tas")
                {
                    kaybeden++;
                }
                if (kullanici == "kagit" && secenek[a] == "tas")
                {
                    kazanan++;
                }
                if (kullanici == "kagit" && secenek[a] == "makas")
                {
                    kaybeden++;
                }
                Console.WriteLine(secenek[a]);
                Console.WriteLine("Kullanıcı pc yi " + kazanan + " kadar yener.");
                Console.WriteLine("Kullanıcı pc ye " + kaybeden + " kadar yenilir.");
            } while (kullanici != "q");
        }

        /*private static void RastgeleOrnek()
        {
            string[] sehir = { "İstanbul", "Ankara", "Karabük" };
            //rastgele bir şehir ekrana yazdırır.
            Random r = new Random();
            int rastgele = r.Next(3);//Max deger gelmez.yani gelebilecek sayilar 0 1 2 olur.
            Console.WriteLine(sehir[rastgele]);
        }*/

        /*private static void RastgeleSayi()
        {
            Random r = new Random();
            int sayi = r.Next(10);//0 ile 9 arasında bir sayı döndürür.
            Console.WriteLine(sayi);
        }*/
    }
}
