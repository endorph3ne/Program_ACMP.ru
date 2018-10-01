using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Числа_Фибоначчи__0147_ {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer: {0}", Fib(n));
            Console.Read();
        }

        static int FibRec(int p1, int p2, int n) {
            return n == 0 ? p1 : FibRec(p2, p1 + p2, n - 1);
        }
        static int Fib(int n) {
            return FibRec(0, 1, n);
        }

    }
}
