using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Разворот__0149_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Развернуть массив
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5 };

            for (int i = arrayOfNumbers.Length - 1; i >= 0; i--)
                Console.Write("{0} ", arrayOfNumbers[i]);

            Console.ReadLine();
        }
    }
}
