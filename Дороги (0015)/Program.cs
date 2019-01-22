using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дороги__0015_ {
    class Program {
        static void Main(string[] args) {
            int[,] array = { {0, 1, 0, 0, 0 },
                             {1, 0, 1, 1, 0 },
                             {0, 1, 0, 0, 1 },
                             {0, 1, 0, 0, 0 },
                             {0, 0, 1, 0, 0 } };

            int sumAllRoad = 0;
            for (int i = 0; i < Math.Sqrt(array.Length); i++) {
                for (int j = 0; j < Math.Sqrt(array.Length); j++) {
                    if (array[i, j] == 1)
                        sumAllRoad++;
                }
            }

            Console.WriteLine($"Answer: {sumAllRoad / 2}");
            Console.Read();
        }
    }
}
