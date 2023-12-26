using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek();
            Console.ReadLine();
        }

        private static void Ornek()
        {
            Console.WriteLine("Aradığınız öğrenci adı soyadı?");
            string a = Console.ReadLine();
            if(string.IsNullOrEmpty(a.Trim()))
            {
                Console.WriteLine("Boş bırakmayınız");
            }
            else if(a.Length < 3)
            {
                Console.WriteLine("En az 3 karakter girmelisin");
            }
            else
            {
                Console.WriteLine("Teşekkürler");
            }
        }
    }
}
