using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Нули__0043_ {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            int countZero = 0;
            int max = 0;

            for (int i = 0; i < input.Length; i++) {
                if (input[i] == '0')
                    countZero++;
                else {
                    if (countZero > max)
                        max = countZero;
                    countZero = 0;
                }
            }

            Console.WriteLine("Answer: {0}", max);
            Console.Read();
        }
    }
}
