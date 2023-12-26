using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList sehirler = new ArrayList();
            sehirler.Add("Mersin");
            sehirler.Add("Adana");
            sehirler.Add(1);
            foreach (var hobaa in sehirler)
            {
                Console.WriteLine(hobaa);
            }*/

            /*List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var can in cities)
            {
                Console.WriteLine(can);
            }*/
            List<Customer> canan = new List<Customer>
            {
                new Customer{Id = 1,Firstname="Can"},
                new Customer { Id = 3, Firstname = "Hasan" }
            };
            /*canan.Add(new Customer { Id = 1, Firstname = "Can" });
            canan.Add(new Customer { Id = 3, Firstname = "Hasan" });*/
            var customer2 = new Customer()
            {
                Id = 5,
                Firstname = "Ossman"
            };
            canan.Add(customer2);
            canan.AddRange(new Customer[2]
                {
                    new Customer{Id = 8,Firstname = "Hakkan"},
                    new Customer{Id = 15,Firstname = "Gülnaz"}
                });
            canan.Clear();
            Console.WriteLine(canan.Contains(customer2));
            /*foreach (var herhangi in canan)
            {
                Console.WriteLine(canan);
                Console.WriteLine(herhangi.Id);
                Console.WriteLine(herhangi.Firstname);
            }*/
            canan.Remove(customer2);//silme işlemi
            canan.Insert(0,customer2)
            var index = canan.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);

            var count = canan.Count;
            Console.WriteLine("Count: {0}", count);

            Console.ReadLine(); 
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
    }
}
