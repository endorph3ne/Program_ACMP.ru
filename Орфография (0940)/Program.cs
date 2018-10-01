using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Орфография__0940_ {
    class Program {
        static void Main(string[] args) {
            int index = 2;
            string word = "ABC";
            string result = string.Empty;

            for (int i = 0; i < word.Length; i++) {
                if (i == index - 1)
                    continue;

                result += word[i];
            }

            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }
    }
}
