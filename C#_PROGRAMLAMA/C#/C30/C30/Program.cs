using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C30
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> can = new Dictionary<string, string>();
                    //Key    value
            can.Add("book", "kitap");
            can.Add("table", "masa");
            can.Add("computer", "bilgisayar");
            //Console.WriteLine(can["book"]);

            foreach (var herhangi in can)
            {
                Console.WriteLine(herhangi.Value);
            }
            Console.WriteLine(can.ContainsKey("book"));
            Console.WriteLine(can.ContainsValue("kitap"));
            Console.ReadLine();
        }
    }
}
