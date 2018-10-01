using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поля__0844_ {
    class Program {
        static void Main(string[] args) {
            string[] inputArray = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(inputArray[0]);
            int b = Convert.ToInt32(inputArray[1]);

            int rectangleArea = a * b;
            double sideSquare = Math.Sqrt(rectangleArea);

            if (Math.Round(sideSquare) - sideSquare == 0)
                Console.WriteLine("Answer: {0}", sideSquare);
            else
                Console.WriteLine("Answer: {0}", 0);

            Console.Read();
        }
    }
}
