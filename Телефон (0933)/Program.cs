using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефон__0933_ {
    class Program {
        static void Main(string[] args) {
            int a = 20;
            int b = 1;
            int c = 3;
            int t = 30;

            if (t > a) {
                int result = a * b + (t - a) * c;
                Console.WriteLine("Answer: {0}", result);
            }
            else 
                Console.WriteLine("Answer: {0}", t * b);

            Console.Read();
        }
    }
}
