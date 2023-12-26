using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiziOrnek();
            //DiziOrnek1();
            //DiziOrnek2();
            Console.ReadLine();
        }

        /*private static void DiziOrnek2()
        {
            string[] sorular = { "33 pılakalı ilimiz?", "Muzu meşhur olan ilçe?", "Mersin hangi bölgede?" };
            string[] cevap = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sorular[i]);
                cevap[i] = Console.ReadLine();
            }
            int dogru = 0;
            int yanlis = 0;
            if(cevap[0] == "Mersin")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            if(cevap[1] == "Anamur")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            if (cevap[2] == "Akdeniz")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            Console.WriteLine("Doğru sayınız " + dogru + "\nYanlış sayınız " + yanlis);
        }*/

        /*private static void DiziOrnek1()
        {
            string[] dosyalar = Directory.GetFiles(@"C:\Users\hasan\OneDrive\Masaüstü\C-C#\C#\C14");
            Console.WriteLine("C sürücüsünde " + dosyalar.Length + " dosyalar");
            Console.WriteLine("İlk dosya");
            Console.WriteLine(dosyalar[0]);
            string[] dosyaalar = dosyalar[0].Split('\\');
            Console.WriteLine(dosyaalar[dosyaalar.Length - 1]);
        }*/

        /*private static void DiziOrnek()
        {
            string tarih = "29.11.2024";
            string[] parcalar = tarih.Split('.');
            Console.WriteLine(parcalar[2]);
            int index = parcalar.Length - 3;
            Console.WriteLine(parcalar[index]);
        }*/
    }
}
