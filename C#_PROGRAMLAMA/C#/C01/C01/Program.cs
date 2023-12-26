using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01
{
    class Program
    {
        //Kullanıcıya kac yasında oldugunu sorun. En guzel yasın kullanıcının yası oldugunu bastırın. Bip sesiyle programı sonlandırın.
        static void Main(string[] args)
        {
            Console.Write("Kac yasındasınız ?");
            var yas = Console.ReadLine();
            Console.WriteLine("En guzel yas " + yas);
            Console.ReadLine();
            int a = Convert.ToInt32(yas);
            for (int i = 0; i < a; i++)
            {
                Console.Beep();
            }
            //Console.Beep();
        }
    }
}
