using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = yıl();
            Console.WriteLine(a);*/
            int yasim = yasibul();
            bool resit = resitmi();
            Console.WriteLine("Yaşınız " + yasim + resit);
            /*int sayi1 = sayiiste();
            int sayi2 = sayiiste();
            Console.WriteLine((sayi1 + sayi2) / 2);*/
            Console.ReadLine();
        }

        private static bool resitmi()
        {
            return yasibul() >= 18;
        }

        private static int yasibul()
        {
            return DateTime.Today.Year - yıl();
        }

        private static int yıl()
        {
            Console.WriteLine("Lütfen doğduğunuz yılı giriniz.");
            return Convert.ToInt32(Console.ReadLine());
        }

        /*private static int sayiiste()
        {
            return Convert.ToInt32(Console.ReadLine());
        }*/
    }
}
