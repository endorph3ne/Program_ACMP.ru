using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Спирт__0757_ {
    class Program {
        static void Main(string[] args) {
            int c = 18;
            int h = 35;
            int o = 32;

            int quantityFromC = c / 2;
            int quantityFromH = h / 6;
            int quantityFromO = o / 1;

            if (quantityFromC < quantityFromH && quantityFromC < quantityFromO)
                Console.WriteLine("Answer: {0}", quantityFromC);
            else if (quantityFromH < quantityFromO)
                Console.WriteLine("Answer: {0}", quantityFromH);
            else 
                Console.WriteLine("Answer: {0}", quantityFromO);

            Console.Read();
        }
    }
}
