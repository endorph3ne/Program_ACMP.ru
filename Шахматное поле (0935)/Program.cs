using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматное_поле__0935_ {
    class Program {
        static void Main(string[] args) {
            string[] inputString = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(inputString[0]);
            int y1 = Convert.ToInt32(inputString[1]);
            int x2 = Convert.ToInt32(inputString[2]);
            int y2 = Convert.ToInt32(inputString[3]);

            if ((x1 + y1) % 2 == (x2 + y2) % 2)
                Console.WriteLine("Answer: YES");
            else
                Console.WriteLine("Answer: NO");

            Console.ReadLine();
        }
    }
}
