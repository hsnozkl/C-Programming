using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C26
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] can = new Person[3]
            {
                new Customer
                {
                    Firstname = "Can"
                },
                new Student
                {
                    Firstname = "Tuba"
                },
                new Person
                {
                    Firstname = "Tuçe"
                }
            };
            foreach (var hoba in can)
            {
                Console.WriteLine(hoba.Firstname);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
