using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наперстки__0678_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] thimbles = { 1, 0, 0 };
            string sequence = "CBABCACCC";

            Console.WriteLine("Answer: {0}", FindThimbleRecursive(thimbles, sequence));
            Console.Read();
        }


        static int FindThimbleRecursive(int[] thimbles, string sequence)
        {
            if (String.IsNullOrEmpty(sequence))
                return FindNumberOfThimble(thimbles);

            if (sequence[0] == 'A')
                Swap(ref thimbles[0], ref thimbles[1]);

            else if (sequence[0] == 'B')
                Swap(ref thimbles[1], ref thimbles[2]);

            else
                Swap(ref thimbles[0], ref thimbles[2]);


            return FindThimbleRecursive(thimbles, sequence.Substring(1));
        }
        static int FindNumberOfThimble(int[] thimbles)
        {
            for (int i = 0; i < thimbles.Length; i++)
                if (thimbles[i] == 1)
                    return i + 1;
            return -1;
        }
        static void Swap(ref int first, ref int second)
        {
            int Sum = first + second;
            second = Sum - second;
            first = Sum - first;
        }
    }
}
