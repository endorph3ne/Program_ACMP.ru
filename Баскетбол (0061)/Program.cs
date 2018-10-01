using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Баскетбол__0061_ {
    class Program {
        static void Main(string[] args) {
            int[,] array = { { 15, 16 },
                             { 18, 17 },
                             { 10, 12 },
                             { 14, 12 } };
            int s1 = 0;
            int s2 = 0;


            for (int i = 0; i < array.Length / 2; i++) {
                s1 += array[i, 0];
                s2 += array[i, 1];
            }

            if (s1 > s2)
                Console.WriteLine("Answer: {0}", "1");
            else if (s1 < s2)
                Console.WriteLine("Answer: {0}", "2");
            else
                Console.WriteLine("Answer: {0}", "DRAW");
            Console.Read();
        }
    }
}
