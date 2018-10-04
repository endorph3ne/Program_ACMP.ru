using System;

namespace Болты_и_гайки__0294_ {
    class Program {
        static void Main(string[] args) {
            string[] nutInfo = Console.ReadLine().Split(' ');
            string[] boltInfo = Console.ReadLine().Split(' ');

            int k1 = Convert.ToInt32(nutInfo[0]);
            int l1 = Convert.ToInt32(nutInfo[1]);
            int m1 = Convert.ToInt32(nutInfo[2]);

            int k2 = Convert.ToInt32(boltInfo[0]);
            int l2 = Convert.ToInt32(boltInfo[1]);
            int m2 = Convert.ToInt32(boltInfo[2]);

            double lostNut = k1 * (double)l1 / 100;
            double lostBolt = k2 * (double)l2 / 100;

            double remainingNut = k1 - lostNut;
            double remainingBolt = k2 - lostBolt;

            if (remainingBolt > remainingNut)
                lostBolt += remainingBolt - remainingNut;
            else
                lostNut += remainingNut - remainingBolt;

            double result = lostNut * m1 + lostBolt * m2;

            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }
    }
}
