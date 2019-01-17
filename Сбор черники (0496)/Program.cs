using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сбор_черники__0496_ {
    class Program {
        static void Main(string[] args) {
            int[] array = { 1, 2, 3, 4 };
            int maxBerries = 0;
            int currentBerries = 0;
            

            if (array.Length == 3)
                Console.WriteLine($"Answer: {array[0] + array[1] + array[2]}");
            else {
                int numberBerriesFirstBush = array[0] + array[1] + array[array.Length - 1];
                int numberBerriesLastBush = array[array.Length - 2] + array[array.Length - 1] + array[0];

                maxBerries = numberBerriesFirstBush > numberBerriesLastBush ? numberBerriesFirstBush : numberBerriesLastBush;

                for (int i = 1; i < array.Length - 1; i++) {
                    currentBerries = 0;
                    currentBerries = array[i - 1] + array[i] + array[i + 1];

                    if (currentBerries > maxBerries)
                        maxBerries = currentBerries;
                }
                Console.WriteLine($"Answer: {maxBerries}");
            }

            
            Console.Read();
        }
    }
}
