using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C28
{
    class Program
    {
        static void Main(string[] args)
        {
            Database can = new Oracle();
            can.Add();
            can.Delete();

            Database canan = new SqlServer();
            canan.Add();
            canan.Delete();
            Console.ReadLine();
        }
    }
    abstract class Database//abtract class new yapılamaz.
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); // bu kısımda içine herhangibir değer girilemez.
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
