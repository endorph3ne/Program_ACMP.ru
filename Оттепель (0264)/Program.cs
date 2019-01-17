using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оттепель__0264_ {
    class Program {
        static void Main(string[] args) {
            int[] array = { 10, 20, 30, 1, -10, 1, 2, 3 };
            int countDaysWithTMoreThan0 = 0;
            int max = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] > 0)
                    countDaysWithTMoreThan0++;
                else {
                    if (countDaysWithTMoreThan0 > max)
                        max = countDaysWithTMoreThan0;
                    countDaysWithTMoreThan0 = 0;
                }

            }
            Console.WriteLine($"Answer: {max}");
            Console.Read();
        }

    }
}
