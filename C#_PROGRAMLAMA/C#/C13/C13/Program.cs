using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13
{
    class Program
    {
        static void Main(string[] args)
        {
            //hata fırlatma
            //Ornek();
            //Loglama();
            Ornek1();
            Console.ReadLine();
        }

        private static void Ornek1()
        {
            try
            {
                Console.WriteLine("500 gr kuruyemişi kaç kişiye paylaştıracaksınız?");
                int kisi = Convert.ToInt32(Console.ReadLine());
                if(kisi == 0)
                {
                    throw new DivideByZeroException();
                }
                double gram = 500.0 / kisi;
                Console.WriteLine("Kisi basi " + gram + " kuruyemis düşer");
            }
            catch(DivideByZeroException sifirHatasi)
            {
                Console.WriteLine("Sıfır Bölme Hatası");
            }
            catch(FormatException formatHatasi)
            {
                Console.WriteLine("Yanlızca sayi giriniz");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Başka bir hata");
            }
        }

        /*private static void Loglama()
        {
            try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if(sayi == 3)
                {
                    throw new Exception("böyle sayi mi olur");
                }
            }
            catch(Exception hata)//hatanın bilgilerine ulaşmak için exception kullanılır
            {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", "\r\n");
                File.AppendAllText("log.txt", hata.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", hata.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine+"*********************"+Environment.NewLine);
            }
            
        }*/

        /*private static void Ornek()
        {
            Console.WriteLine("Aklından 1 ile 3 arasında bir değer tut");
            string sayi = Console.ReadLine();
            switch(sayi)
            {
                case "1":
                    throw new Exception("beğenmedim");
                    break;
                case "2":
                    throw new Exception("başka sayı bulamadın mı");
                    break;
                case "3":
                    throw new Exception("böyle sayı mı olur çalışmıyorum");
                    break;
            }
        }*/
    }
}
