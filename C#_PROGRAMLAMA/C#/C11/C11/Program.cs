using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarihsaat();
            //FarkliTarih();
            //Surehesap();
            //CikisinaNeKadarVar();
            //IleriTarih();
            //TarihFormat();
            //Ornek();
            Ornek1();
            Console.ReadLine();
        }

        private static void Ornek1()
        {
            Console.WriteLine("Lütfen doğum tarihini giriniz.");
            DateTime dogum = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dogum.DayOfWeek);
            int gun = (int)(DateTime.Today - dogum).TotalDays;
            Console.WriteLine(gun);
            int yıl = gun / 365;
            Console.WriteLine(yıl);
        }

        /*private static void Ornek()
        {
            DateTime simdi = DateTime.Now;
            DateTime ongunSonra = simdi.AddDays(10);
            Console.WriteLine(ongunSonra.ToString("dd.MM.yyyy"));
        }*/

        /*private static void TarihFormat()
        {
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString());
            Console.WriteLine(simdi.ToLongDateString());
            Console.WriteLine(simdi.ToShortTimeString());
            Console.WriteLine(simdi.ToLongTimeString());
            //MM ay (sayı) MMMM ay (yazı)  dd gün  yyyy yıl  hh saat(12)  HH saat(24)
            Console.WriteLine(simdi.ToString("MM/dd/yyyy MMMM dd - can hh:mm HH:mm"));
        }*/

        /*private static void IleriTarih()
        {
            DateTime bugun = DateTime.Today;
            DateTime birAySonra = bugun.AddMonths(1);
            DateTime birAyOnce = bugun.AddMonths(-1);
            DateTime birGunSonrasi = bugun.AddDays(1);
            DateTime birGunOncesi = bugun.AddDays(-1);
            Console.WriteLine("Bir ay sonrası : " + birAySonra);
            Console.WriteLine("Bir ay öncesi : " + birAyOnce);
            Console.WriteLine("Bir gün sonrası : " + birGunSonrasi);
            Console.WriteLine("Bir gün öncesi : " + birGunOncesi);
        }*/

        /*private static void CikisinaNeKadarVar()
        {
            var simdi = DateTime.Now;
            var cikis = Convert.ToDateTime("2024-12-02 23:00:00");
            //var cikisim = new DateTime(2024, 12, 02, 23, 0, 0);
            TimeSpan sure = cikis - simdi;
            Console.WriteLine("Toplam " + sure.TotalMinutes + "dk");
            Console.WriteLine("Çıkışa " + sure.Hours + " saat " + sure.Minutes + " dk kaldı");
        }*/

        /*private static void Surehesap()
        {
            DateTime mezuniyet = new DateTime(2024, 06, 20);
            TimeSpan kalansure = mezuniyet - DateTime.Today;
            Console.WriteLine(kalansure);
            Console.WriteLine(kalansure.TotalDays);
        }*/

        /*private static void FarkliTarih()
        {
            DateTime tarih = Convert.ToDateTime("2019-01-01");//veritabanında yıl ay gün şeklinde tutulur.
            Console.WriteLine(tarih);
            DateTime mezuniyet = new DateTime(2024, 06, 20);
            Console.WriteLine("Yılın " + mezuniyet.DayOfYear + ". günü.");
            Console.WriteLine(mezuniyet.DayOfWeek);
        }*/

        /*private static void Tarihsaat()
        {
            DateTime bugun = DateTime.Today;
            Console.WriteLine(bugun);
            DateTime simdi = DateTime.Now;
            Console.WriteLine(simdi);
        }*/
    }
}
