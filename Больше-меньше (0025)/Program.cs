using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больше_меньше__0025_ {
    class Program {
        static void Main(string[] args) {
            int a = 5;
            int b = 7;

            if (a > b)
                Console.WriteLine("Answer: {0}", ">");
            else if (a < b)
                Console.WriteLine("Answer: {0}", "<");
            else
                Console.WriteLine("Answer: {0}", "=");
            Console.Read();
        }
    }
}
