using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Всем_известно__0839_ {
    class Program {
        static void Main(string[] args) {
            string sequence = "1111111111111111";

            if (sequence.Contains("0"))
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");

            Console.Read();
        }
    }
}
