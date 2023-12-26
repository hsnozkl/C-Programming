using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C27
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer can = new SqlServer();
            can.Add();
            MysqlServer canan = new MysqlServer();
            canan.Add();
            can.Deleted();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Deleted()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Eklendi");
        }
        public override void Deleted()
        {
            Console.WriteLine("Silindi");
        }
    }
    class MysqlServer : Database
    {

    }
}
