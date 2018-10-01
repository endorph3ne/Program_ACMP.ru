using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Торт__0539_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            if (n % 2 == 0)
                Console.WriteLine("Answer: {0}", n / 2);
            else
                Console.WriteLine("Answer: {0}", n);
            Console.Read();
        }
    }
}
