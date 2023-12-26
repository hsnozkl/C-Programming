using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = yıl();
            rakamlar();
            Console.ReadLine();
        }

        private static void rakamlar()
        {
            int yaslar = yasibul();
            int a = yaslar / 10;
            int b = yaslar % 10;
            int toplam = 0;
            for (int i = 0; i < yaslar; i++)
            {
                toplam+= i;
            }
            Console.WriteLine("Yaşınız " + yaslar + "\nYaşlar toplamı " + toplam);
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
    }
}
