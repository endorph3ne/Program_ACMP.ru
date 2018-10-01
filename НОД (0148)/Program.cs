using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НОД__0148_
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1000000000;
            int second = 1;
            int result;

            result = first >= second ? NOD(first, second) : NOD(second, first);
            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }

        //Алгоритм Евклида
        static int NOD(int first, int second)
        {
            if (second == 0)
                return first;

            int temp = first % second;
            return NOD(second, temp);
        }
    }
}
