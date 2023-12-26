using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {
            NullableNedir();
            Console.ReadLine();
        }

        private static void NullableNedir()
        {
            string a = null;
            //string bir class olduğu için null olabilir.
            //Hata: int ve double struct olduklarından null olamazlar.
            /*int sayi1 = null;
            double sayi2 = null;*/

            Nullable<int> sayi = null;
            int? bosSayi = null;
            DateTime tarih = new DateTime();
            Console.WriteLine(a);
            Console.WriteLine(sayi);
            Console.WriteLine(bosSayi);
            Console.WriteLine(tarih);
        }
    }
}
