using System;

namespace Две_окружности__0026_ {
    class Program {
        static void Main(string[] args) {
            string[] firstStringArray = Console.ReadLine().Split(' ');
            string[] secondStringArray = Console.ReadLine().Split(' ');

            int[] firstCircleParameters = new int[firstStringArray.Length];
            int[] secondCircleParameters = new int[secondStringArray.Length];

            for (int i = 0; i < firstStringArray.Length; i++)
                firstCircleParameters[i] = Convert.ToInt32(firstStringArray[i]);
            for (int i = 0; i < secondStringArray.Length; i++)
                secondCircleParameters[i] = Convert.ToInt32(secondStringArray[i]);

            int deltaX = secondCircleParameters[0] - firstCircleParameters[0];
            int deltaY = secondCircleParameters[1] - firstCircleParameters[1];

            int sumTwoRadius = firstCircleParameters[2] + secondCircleParameters[2]; 
            double distanceBetweenTwoCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            string result = distanceBetweenTwoCenters <= sumTwoRadius ? "YES" : "NO";
            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }
    }
}
