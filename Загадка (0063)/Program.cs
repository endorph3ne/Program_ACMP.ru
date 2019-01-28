using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Загадка__0063_ {
    class Program {
        static void Main(string[] args) {
            int P = 6;
            int S = 5;

            double D = S * S - 4 * P;
            int x1 = (int)((S - Math.Sqrt(D)) / 2);
            int x2 = S - x1;

            Console.WriteLine($"Answer: {x1} {x2}");
            Console.Read();
        }
    }
}
