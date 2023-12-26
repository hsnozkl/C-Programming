using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = yıl();
            int x = rakamlar();
            sayfarengi();
            Console.WriteLine("Rakamlar toplamı " + x + "kadardır");
            Console.ReadLine();
        }

        private static void sayfarengi()
        {
            if(rakamlar() % 2 == 0 || resitmi())
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
        }

        private static int rakamlar()
        {
            int yaslar = yasibul();
            int a = yaslar / 10;
            int b = yaslar % 10;
            return a + b;
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
        private static bool resitmi()
        {
            return yasibul() >= 18;
        }
    }
}
