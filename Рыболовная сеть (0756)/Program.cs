using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рыболовная_сеть__0756_ {
    class Program {
        static void Main(string[] args) {
            int m = 3;
            int n = 2;

            if (m == 1 || n == 1)
                Console.WriteLine("0");

            int numberOfCells = (m - 1) * (n - 1);

            Console.WriteLine("Answer: {0}", numberOfCells);
            Console.Read();
        }
    }
}
