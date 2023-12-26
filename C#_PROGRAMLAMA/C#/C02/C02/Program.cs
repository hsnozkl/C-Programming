using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Convert sınıfının Toint32 metoduna "78" parametresini gönderin. Bu ifadeyi bir değişkene atayın ve ekrana bastırın.
            /*string a = "78";
            int cevir = Convert.ToInt32(a);
            Console.WriteLine(cevir);
            Console.ReadLine();*/

            //Console sınıfının Title elemanını, BackgroundColor elemanını, CorsorSize elemanını değiştirin.

            /*Console.Title = "Hasan";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.CursorSize = 60;
            Console.CursorLeft = 60;
            Console.CursorTop = 15;
            Console.WriteLine("Deneme");
            Console.ReadLine();*/

            //Console sınıfının Readline metodundan dönen değeri bir değişkene atayın.
            //Convert sınıfının Toınt32 metoduna değişkeni paremetre olarak gönferin.
            //Bu ifadeyi başka bir değişkene atayın.

            /*var can = Console.ReadLine();
            int boz = Convert.ToInt32(can);
            Console.WriteLine(boz);
            Console.ReadLine();*/

            //-pc: Kaç yasındasın ? -k: 45   -pc:40 yasında gosteriyorsunz

            /*Console.WriteLine("Kac yasindasiniz ?");
            var yas = Console.ReadLine();
            int a = Convert.ToInt32(yas);
            a -= 5;
            Console.WriteLine(a + " yasinda gösteriyorsunuz");
            Console.Read();*/

            //-Pc: Kaç lira alisveris yaptin ? K:100  (%10 indirim uygulandi) Pc:10 tl indirim kazandi

            /*Console.WriteLine("Kac Tl alisveris yaptiniz");
            var b = Console.ReadLine();
            int x = Convert.ToInt32(b);
            int y = (x * 10) / 100;
            x -= y;
            Console.WriteLine(x + " Tl odeminiz bulunuyor." + y + " Tl indirim kazandiniz.");
            Console.Read();*/

            //Environment sınıfının TickCount elemanını bir değişkene atayın. ms cinsinden olan bu değeri dakika olarak ekrana yazdırın.
            //not: küsüratlı olabilsin.

            /*var tms = Environment.TickCount;
            var ts = tms / 60;
            var dk = ts / 60;
            var s = dk / 60;
            Console.WriteLine(s + " saat");
            Console.ReadLine();*/

            //DateTime sınıfının Today elemanının Year elemanını bir değişkene atayalım.
            //DateTime sınıfının Today elemanının Month elemanını bir değişkene atayalım.
            //DateTime sınıfının Today elemanının Day elemanını bir değişkene atayalım.
            //Yarının tarihini ekrana bastırsın. ö: 05.11.2023

            /*int yıl = DateTime.Today.Year;
            int ay = DateTime.Today.Month;
            int gun = DateTime.Today.Day + 1;
            Console.WriteLine(gun + "." + ay + "." + yıl);
            Console.ReadLine();*/

            //Kullanıcıdan 1-5 arası bir sayı istiyelim. Math ınıfının PI elemanını bir değişkene atayalım.
            //Not: küsüratsız  -iki değeri çarpıp ekrana yazdıralım.

            Console.WriteLine("Lutfen 1 - 5 arasinda bir sayi giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double a = Math.PI;
            int kusursuz = Convert.ToInt32(a);
            Console.WriteLine(kusursuz * sayi);
            Console.ReadLine();


        }
    }
}
