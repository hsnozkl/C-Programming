using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C24
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManeger customerManeger = new CustomerManeger();
            //customerManeger.Add(new OracleServerCustomerDal());
            InterfaceGercekHayat[] yeni = new InterfaceGercekHayat[3]
            {
                new OracleServerCustomerDal(),
                new MysqlServerCustomerDal(),
                new SqlServerCustomerDal()
            };
            foreach (var bum in yeni)
            {
                bum.Add();
                bum.Delete();
                bum.Update();
            }

            Console.ReadLine();
        }
    }
}
