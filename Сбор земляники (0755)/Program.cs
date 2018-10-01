using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сбор_земляники__0755_ {
    class Program {
        static void Main(string[] args) {
            int x = 12;
            int y = 13;
            int z = 35;

            if (x + y < z)
                Console.WriteLine("Impossible");
            else
                Console.WriteLine("Answer: {0}", x + y - z);
            Console.Read();
        }
    }
}
