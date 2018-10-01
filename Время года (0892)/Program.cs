using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время_года__0892_ {
    class Program {
        static void Main(string[] args) {
            int n = 3;

            if (n == 1 || n == 2 || n == 12)
                Console.WriteLine("Winter");
            else if (n >= 3 && n <= 5)
                Console.WriteLine("Spring");
            else if (n >= 6 && n <= 8)
                Console.WriteLine("Summer");
            else if (n >= 9 && n <= 11)
                Console.WriteLine("Autumn");
            else
                Console.WriteLine("Error");
            Console.Read();
        }
    }
}
