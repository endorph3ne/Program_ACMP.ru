using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Три_толстяка__0754_
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1 = 99;
            int m2 = 106;
            int m3 = 214;

            if (m1 < 94 || m2 < 94 || m3 < 94)
            {
                Console.WriteLine("Error");
                Console.Read();
                return;
            }
                
            if (m1 > 727 || m2 > 727 || m3 > 727)
            {
                Console.WriteLine("Error");
                Console.Read();
                return;
            }

            if (m1 > m2 && m1 > m3)
                Console.WriteLine("Answer: {0}", m1);
            else if (m2 > m3)
                Console.WriteLine("Answer: {0}", m2);
            else
                Console.WriteLine("Answer: {0}", m3);
            Console.Read();
        }
    }
}
