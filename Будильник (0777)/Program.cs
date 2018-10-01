using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Будильник__0777_ {
    class Program {
        static void Main(string[] args) {
            int s = 8;
            int t = 7;

            if (s == t)
                Console.WriteLine("Answer: {0}", 12);
            else if (t > s) 
                Console.WriteLine("Answer: {0}", t - s);
            else if (s > t) 
                Console.WriteLine("Answer: {0}", Math.Abs(s - 12) + Math.Abs(t - 12));
            Console.Read();
        }
    }
}
