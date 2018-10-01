using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплата__0021_ {
    class Program {
        static void Main(string[] args) {
            int a = 100;
            int b = 500;
            int c = 1000;

            int max;
            if (a > b && a > c)
                max = a;
            else if (b > c)
                max = b;
            else
                max = c;

            int min;
            if (a < b && a < c)
                min = a;
            else if (b < c)
                min = b;
            else
                min = c;

            Console.WriteLine("Answer: {0}", max - min);
            Console.Read();

        }
    }
}
