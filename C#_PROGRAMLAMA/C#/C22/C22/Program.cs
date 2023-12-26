using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CustomerManeger can = new CustomerManeger(20);
            can.List();
            Product canan = new Product
            { 
                Id = 1,
                Name = "Computer" 
            };
            Product urun = new Product(2, "Laptop");
            urun.Hoba();*/

            /*EmployeeManeger can = new EmployeeManeger(new Filelogger());
            //can.logger = new Filelogger(); bu kısma gerek kalmadı.
            can.Add();*/
            Personmaneger canan = new Personmaneger("Can");
            canan.Add();

            Manager.DoSomething();
            Manager can = new Manager();
            can.DoSomething2();
            Teacher.Number = 15;

            Console.ReadLine();
        }
    }
    class CustomerManeger
    {
        private int _count = 10;
        public CustomerManeger(int a)
        {
            _count = a;
        }
        public CustomerManeger() //ctor ile gelir.
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public int Id { get; set; }//prop ile oluşturulur.
        public string Name { get; set; }
        private int _id;
        private string _name;

        public Product(int id,string isim)
        {
            _id = id + 5;
            _name = isim + "boz";
        }
        public Product()
        {

        }
        public void Hoba()
        {
            Console.WriteLine(_id + _name);
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class Filelogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManeger 
    {
        private ILogger _logger;
        public EmployeeManeger(ILogger canan)
        {
            _logger = canan;
        }
        public ILogger logger { get; set; }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class Baseclass
    {
        private string _entity;
        public Baseclass(string can)
        {
            _entity = can;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class Personmaneger:Baseclass
    {
        public Personmaneger(string hoba):base(hoba)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
    }
}


