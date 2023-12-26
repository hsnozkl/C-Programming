using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C00
{
    class Program
    {
        //Kullanıcıya bugun nasılsın diye sorun
        // kullanıcı ıyıyım derse bende ıyıyım kotuyum derse bende kotuyum dıye cevap verın
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba !");
            Console.Write("Bugun nasılsın ?");
            string hal = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ben de " + hal);
            Console.ReadLine();
        }
    }
}
