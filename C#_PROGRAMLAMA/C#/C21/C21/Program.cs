using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager a = new CustomerManager();
            a.add();
            a.update();
            ProductManager b = new ProductManager();
            b.add();
            b.update();

            Customer hakan = new Customer();
            hakan.City = "Bursa";
            hakan.Id = 2;
            hakan.Firstname = "Hakan";
            hakan.Lastname = "Taşdelen";

            Customer mazlum = new Customer
            {
                Id = 1,City= "Elazig",Firstname = "Mazlum",Lastname = "Gün"
            };
            Console.WriteLine(mazlum.Firstname);
            Console.ReadLine();
        }
    }
}
