using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alfabe();
            //Ornek();
            //Asalmi();
            AsalOrnek();
            Console.ReadLine();
        }

        private static void AsalOrnek()
        {
            int kactane = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (IsAsal(i))
                    kactane++;
            }
            Console.WriteLine("1-50 arasında " + kactane + " tane asal sayı vardır.");
        }

        private static bool IsAsal(int sayi)
        {
            bool asalmi = true;
            if (sayi == 1 || sayi == 0)
                return false;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    asalmi = false;
            }
            return asalmi;
        }


        /*private static void Asalmi()
        {
            Console.WriteLine("Lütfen bir sayi giriniz.");
            int a = Convert.ToInt32(Console.ReadLine());
            bool asalmi = true;
            if (a == 1 || a == 0)
            {
                throw new Exception("Başka sayı girmeliydiniz.");
            }                
            for (int i = 2; i < a; i++)
            {
                if(a % i == 0)
                {
                    asalmi = false;
                }
            }
            if(asalmi)
            {
                Console.WriteLine("Asal");
            }
            else
            {
                Console.WriteLine("Asal değil");
            }
        }*/

        /*private static void Ornek()
        {
            string x = "*";
            int i = 1;
            while (i < 9)
            {                
                int a = 0;
                while( a < i)
                {
                    Console.Write(x);                   
                    a++;
                }                
                Console.Write('\n');
                i++;
            }
            for (int c = 0; c < 10; c++)
            {
                for (int v = 0; v < c; v++)
                {
                    Console.Write(x);
                }
                Console.Write('\n');
            }
            
        }*/

        /*private static void Alfabe()
        {
            for (int i = 'A'; i <= 'Z'; i++)
            {
                Console.Write((char)i + " ");
            }
        }*/
    }
}
