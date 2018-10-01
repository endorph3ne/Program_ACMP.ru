using System;

namespace Манхэттенские_улицы__0817_ {
    class Program {
        static void Main(string[] args) {
            string[] inputStringArray = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(inputStringArray[0]);
            int m = Convert.ToInt32(inputStringArray[1]);
            int d = Convert.ToInt32(inputStringArray[2]);
            int k = Convert.ToInt32(inputStringArray[3]);

            int result = (n + m) * (d * k) - n * m * d * d;
            Console.WriteLine("Answer: {0}", result);
            Console.ReadLine();
        }
    }
}