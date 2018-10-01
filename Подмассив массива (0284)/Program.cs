using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подмассив_массива__0284_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int startValue = 2;
            int endValue = 6;
            int startIndexSubArray = 0;
            int endIndexSubArray = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] == startValue)
                {
                    startIndexSubArray = i;
                    break;
                }

            for (int i = startIndexSubArray; i < array.Length; i++)
                if (array[i] == endValue)
                {
                    endIndexSubArray = i;
                    break;
                }

            Console.WriteLine("Answer:");
            for (int i = startIndexSubArray; i <= endIndexSubArray; i++)
                Console.Write("{0} ", array[i]);
            Console.Read();
        }
    }
}
