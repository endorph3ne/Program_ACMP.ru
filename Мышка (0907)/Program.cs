using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мышка__0907_ {
    class Program {
        static void Main(string[] args) {
            int w = 4;
            int h = 7;
            int r = 3;

            if (w < h) {
                Console.WriteLine(IsFirstGreaterOrEqual(w / 2, r));
            }
            else {
                Console.WriteLine(IsFirstGreaterOrEqual(h / 2, r));
            }
            Console.Read();
        }

        public static string IsFirstGreaterOrEqual(int first, int second) {
            if (first >= second)
                return "YES";
            else
                return "NO";
        }
    }
}
