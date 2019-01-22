using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уравнение__0010_ {
    class Program {
        static void Main(string[] args) {
            long a = Convert.ToInt64(Console.ReadLine());
            long b = Convert.ToInt64(Console.ReadLine());
            long c = Convert.ToInt64(Console.ReadLine());
            long d = Convert.ToInt64(Console.ReadLine());

            List<long> result = new List<long>();

            for (int i = -100; i <= 100; i++) {
                if (a * i * i * i + b * i * i + c * i + d == 0)
                    result.Add(i);
            }

            Console.Write("Answer: ");
            foreach (long current in result)
                Console.Write($"{current} ");

            Console.ReadLine();
        }
    }
}
