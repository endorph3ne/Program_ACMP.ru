using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прямоугольный_параллелепипед__0819_ {
    class Program {
        static void Main(string[] args) {
            int a = 1;
            int b = 1;
            int c = 1;

            int sq = a * b * 2 + b * c * 2 + c * a * 2;
            int v = a * b * c;

            Console.WriteLine("Square surface: {0}\nVolume: {1}", sq, v);
            Console.Read();
        }
    }
}
