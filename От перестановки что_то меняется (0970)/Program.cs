using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace От_перестановки_что_то_менятеся___0970_ {
    class Program {
        static void Main(string[] args) {
            int a1 = 3;
            int a2 = 9;
            int a3 = 2;

            if (a1 + a2 == a3 || a1 + a3 == a2 || a2 + a3 == a1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.Read();
        }
    }
}
