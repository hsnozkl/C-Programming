using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C21
{
    class Customer
    {
        public string City { get; set; } //değeralıyorsam get değer veriyorsam set çalışır.
        public int Id { get; set; }
        private string _Firstname;
        public string Firstname 
        { 
            get { return "Mrs." + _Firstname;} //get değeri geri döndürür yani return eder.
            set { _Firstname = value; } 
        }
        public string Lastname { get; set; }
    }
}
