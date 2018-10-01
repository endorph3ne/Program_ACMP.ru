using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кипячение_чая__0818_ {
    class Program {
        static void Main(string[] args) {
            int n = 3;
            int[] array = new int[] { 2, 5, 4 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++) 
                sum += array[i];

            Console.Write("Answer: {0}", sum - (n - 1));
            Console.Read();
        }
    }
}
