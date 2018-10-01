using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игральные_кубики__0929_ {
    class Program {
        static void Main(string[] args) {
            int n = 22;
            int min = 0;
            int max = 0;

            int integerPart = n / 6;
            int remainderDivision = n % 6;

            if (remainderDivision == 0) {
                min = integerPart;
            }
            else {
                min = integerPart + (6 - remainderDivision + 1);
            }

            max = n / 1 * 6;

            Console.WriteLine("Answer: {0} {1}", min, max);
            Console.Read();
        }
    }
}
