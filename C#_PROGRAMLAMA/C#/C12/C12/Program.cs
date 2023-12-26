using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek1();
            Console.ReadLine();
        }

        private static void Ornek1()
        {
            Console.WriteLine("Lütfen sınav notunuzu giriniz.");
            
            /*try 
            {
                int not = Convert.ToInt32(Console.ReadLine());
                if (not >= 0 && not <= 50)
                {
                    Console.WriteLine("Daha çok çalışmalısın.");
                }
                else if(not > 50 && not < 70)
                {
                    Console.WriteLine("Daha iyi olabilir");
                }
                else if(not >= 70 && not <= 100)
                {
                    Console.WriteLine("Başarılı");
                }
            }
            catch 
            {
                Console.WriteLine("Sayı girmediniz. İşlem devam edilmiyor.");
            }*/
            int not1 = Convert.ToInt32(Console.ReadLine());
            string mesaj = not1 < 50 ? "Daha çok çalışmalısın" :
              not1 <= 70 ? "Daha iyi olabilirsin" :
              not1 >= 70 ? "Başarılı" :
              "Yanlış giriş.";
        }
    }
}
