using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07
{
    class Program
    {
        static void Main(string[] args)
        {
            //eğer fazla eşitlik kullanılıyorsa switch kullanılır.
            //SwitchUsing();
            //pc: dil seçiniz (tr/en/de) seçilen dile göre "Merhaba/Hello/Hallo" yazdır.
            //SwitchOrnek();
            //kullanıcıya cinsiyetini kilosunu ve boyunu sor. endeks = kilo/boy*boy
            //erkekler için normal endek 20-25 kadınlar için 19-24
            //endeks fazla ise zayıflamalısın az ise kilo almalısın diye cevap.
            SwitchOrnek1();
            Console.ReadLine();
        }

        private static void SwitchOrnek1()
        {
            Console.WriteLine("Cinsiyetinizi seçiniz.(er/kd)");
            string cinsiyet = Console.ReadLine();
            Console.WriteLine("Kilonuzu giriniz.");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz.");
            double boy = Convert.ToDouble(Console.ReadLine());
            double metre = boy / 100;
            double endeks = kilo / (metre * metre);
            /*if(cinsiyet == "kd" && endeks > 24)
            {
                Console.WriteLine("Kilonuz fazla biraz zayıflayın.");
            }
            if (cinsiyet == "kd" && endeks < 19)
            {
                Console.WriteLine("Fazla zayıfsınız. Biraz kilo alınız.");
            }
            if (cinsiyet == "er" && endeks > 25)
            {
                Console.WriteLine("Kilonuz fazla biraz zayıflayın.");
            }
            if (cinsiyet == "er" && endeks < 20)
            {
                Console.WriteLine("Fazla zayıfsınız. Biraz kilo alınız.");
            }
            else 
            {
                Console.WriteLine("Yanlış cinsiyet girdiniz.");
            }*/

            switch(cinsiyet)
            {
                case "kd":
                    Console.WriteLine(endeks < 19 ? "Zayıfsınız." : endeks < 24 ? "İdeal kilo" : "Kilonuz fazla");
                    break;
                case "er":
                    Console.WriteLine(endeks < 20 ? "Zayıfsınız." : endeks < 25 ? "İdeal kilo" : "Kilonuz fazla");
                    break;
                default:
                    Console.WriteLine("Lütfen doğru cinsiyet giriniz.");
                    break;
            }
            Console.WriteLine(endeks);
            /*if(cinsiyet == "er")
            {
                switch(endeks)
                {
                    case endeks > 25:
                        Console.WriteLine("Endeksiniz : " + endeks + "\nBiraz kilo vermelisiniz.");
                        break;

                }
            }*/
        }

        /*private static void SwitchOrnek()
        {
            Console.WriteLine("Lütfen bir dil giriniz.(tr/en/de)");
            string dil = Console.ReadLine();
            switch(dil)
            {
                case "tr":
                    Console.WriteLine("Merhaba");
                    break;
                case "en":
                    Console.WriteLine("Hello");
                    break;
                case "de":
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("Böyle bir dil yok");
                    break;
            }
        }*/

        /*private static void SwitchUsing()
         * 
        {
            ConsoleColor renk = Console.BackgroundColor;
            switch(renk)
            {
                case ConsoleColor.Black:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case ConsoleColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
        }*/
    }
}
