using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фибоначчиева_последовательность__0949_ {
    class Program {
        static void Main(string[] args) {
            string[] inputStringArray = Console.ReadLine().Split(' ');
            int n = Int32.Parse(inputStringArray[0]);
            int aCurrent = Int32.Parse(inputStringArray[1]);
            int aNext = Int32.Parse(inputStringArray[2]);

            var result = FindFirstElimentsInSequence(n, aCurrent, aNext);
            Console.WriteLine($"Answer: {result.first} {result.second}");
            Console.Read();
        }

        static (int first, int second) FindFirstElimentsInSequence(int n, int aCurrent, int aNext) {
            if (n == 1) {
                var result = (aCurrent, aNext);
                return result;
            }

            return FindFirstElimentsInSequence(n - 1, aNext - aCurrent, aCurrent);
        }
    }
}
