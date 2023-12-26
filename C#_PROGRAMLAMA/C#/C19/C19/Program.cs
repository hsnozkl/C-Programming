using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19
{
    class Program
    {
        static void Main(string[] args)
        {
            BreakVeContinue();
            Console.ReadLine();
            
        }

        private static void BreakVeContinue()
        {
            //Break: döngüyü sonlandırır.
            //Contimue ise bir sonraki adıma geçer.
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }*/
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                if (i == 7)
                    break;
                    Console.WriteLine(i);
            }
        }
    }
}
