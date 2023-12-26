using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ornek1();
            //Ornek2();
            //Kullanıcıdan yaşını isteyin.Aldığımız cevaba göre: Eğer kişi reşit ise "ehliyet alabilir" değil ise "eğliyet alamaz."
            //Ornek3();
            //PC:Hangi programlama dilini seviyorsun?  -k:.....  
            //aldığı cevaba göre; c# olarak girilirse "harika!" pshp olarak girilirse "güzelmiş" başaka girilirse "ama c# daha da güzel"
            //Ornek4();
            //pc: kare mi daire mi? kare ise "kenar uzunluğu" daire ise "yarıçapı" alanını hesaplayıp ekrana bastır.
            //karealan = kare x kare   daire alan = yarıçapın karesi x pi (Math.PI - Math.Pow)
            Ornek(5);
            //Türkiye'nin başkenti ? -Almanya hangi kıtada ? -Renkleri sarı lacivert olan takım ?
            //doğru ve yanlış sayısı ekrana bastır.
            Console.ReadLine();
        }

        private static void Ornek(int v)
        {
            int dogru = 0;
            int yanlis = 0;
            Console.WriteLine("Türkiye'nin başkenti ?");
            string bas = Console.ReadLine();
            if (bas == "ankara" || bas == "ANKARA")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            Console.WriteLine("Almanya hangi kıtada ?");
            string kıt = Console.ReadLine();
            if (kıt == "avrupa" || kıt == "AVRUPA")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            Console.WriteLine("Renkleri sarı lacivert olan takım ?");
            string tkm = Console.ReadLine();
            if (tkm == "fenerbahçe" || tkm == "FENERBAHÇE")
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            Console.WriteLine("Doğru = " + dogru + "\nYanlış = " + yanlis);
        }

        /*private static void Ornek4()
        {
            Console.WriteLine("Kare mi daire mi ?");
            string x = Console.ReadLine();
            if (x == "kare" || x == "KARE")
            {
                Console.WriteLine("Karenin uzunluğunu giriniz.");
                double Kuz = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Karenin alanı = " + Kuz * Kuz);
            }
            else if(x == "daire" || x == "DAİRE")
            {
                Console.WriteLine("Dairenin yarıçapını giriniz.");
                double Ycap = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dairenin alanı = " + Math.PI * Math.Pow(Ycap, 2));
            }
        }*/

        /*private static void Ornek3()
        {
            Console.WriteLine("Hangi programlama dilini seviyorsun ?");
            string dil = Console.ReadLine();
            if (dil == "c#" || dil == "C#")
            {
                Console.WriteLine("Harika!");
            }
            else if (dil == "PHP" || dil == "php")
            {
                Console.WriteLine("Güzelmiş");
            }
            else
            {
                Console.WriteLine("Ama C# daha da güzel.");
            }

        }*/

        /*private static void Ornek2()
        {
            Console.WriteLine("Kaç yaşındasınız.");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 18)
            {
                Console.WriteLine("Ehliyet almak için yaşınız yeterli.");
            }
            else
            {
                Console.WriteLine("Ehliyet almak için yaşınız küçük.");
            }
        }*/

        /*private static void Ornek1()
        {
            if (true)
            {
                Console.WriteLine("Bu kod her zaman çalışır");
            }
            if (DateTime.Today.Day == 13)
            {
                Console.WriteLine("Ayın 13 ü indirim zamanı");
            }
            else if (DateTime.Today.Day == 12)
            {
                Console.WriteLine("Çok az kaldı ! Yarın indirim var");
            }
            else
            {
                Console.WriteLine("İndirim için ayın 13 ünü bekleyin");
            }
        }*/
    }
}
