using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C24
{
    interface InterfaceGercekHayat
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql update");
        }
    }
    class OracleServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle update");
        }
    }
    class MysqlServerCustomerDal : InterfaceGercekHayat
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql update");
        }
    }
    class CustomerManeger
    {
        public void Add(InterfaceGercekHayat can)
        {
            can.Add();
        }
    }
}
