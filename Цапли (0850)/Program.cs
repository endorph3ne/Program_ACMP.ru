using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цапли__0850_ {
    class Program {
        static void Main(string[] args) {
            int a = 3;
            int b = 4;

            int minA = (a + 1) / 2;
            int maxA = a;
            int minB = (b + 1) / 2;
            int maxB = b;

            //Ищем пересечение отрезков
            int lowerBound = Math.Max(minA, minB);
            int upperBound = Math.Min(maxA, maxB);

            Console.WriteLine("Answer: {0} {1}", lowerBound, upperBound);
            Console.Read();
        }
    }
}
