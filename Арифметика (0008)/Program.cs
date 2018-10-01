using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметика__0008_ {
    class Program {
        static void Main(string[] args) {
            int a = 16;
            int b = 19;
            int c = 777;

            if (a * b == c)
                Console.WriteLine("Answer: {0}", "YES");
            else
                Console.WriteLine("Answer: {0}", "NO");
            Console.Read();
        }
    }
}
