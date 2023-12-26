using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C23
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer can = new Customer()
            {
                Id = 1,
                Firstname = "Can",
                Lastname = "Boz",
                Adress = "Istanbul"
            };

            Student ogrenci = new Student()
            {
                Id = 1,
                Firstname = "Can",
                Lastname = "Boz",
                Departmant = "Industrial Engineering"
            };
            manager.Add(ogrenci);
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson canan)
        {
            Console.WriteLine(canan);
        }
    }
}
