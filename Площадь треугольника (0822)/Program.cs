using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Площадь_треугольника__0822_ {
    class Program {
        static void Main(string[] args) {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 3;
            int x3 = 3;
            int y3 = 0;

            double a = Math.Sqrt((double)((x2 - x1) * (x2 - x1)) + (double)((y2 - y1) * (y2 - y1)));
            double b = Math.Sqrt((double)((x3 - x2) * (x3 - x2)) + (double)((y3 - y2) * (y3 - y2)));
            double c = Math.Sqrt((double)((x3 - x1) * (x3 - x1)) + (double)((y3 - y1) * (y3 - y1)));

            double p = (a + b + c) / 2;

            Console.WriteLine("Answer: {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.Read();
        }
    }
}
