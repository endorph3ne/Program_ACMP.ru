using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра__0004_ {
    class Program {
        static void Main(string[] args) {
            int k = 5;
            int secondDigit = 9;
            int lastDigit = secondDigit - k;

            string result = k.ToString() + secondDigit.ToString() + lastDigit.ToString();

            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }
    }
}
