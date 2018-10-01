using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Внеземные_гости__0597_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Радиусы полей и летающих тарелок
            int rLea = 10;
            int rFirstUFO = 3;
            int rSecondUFO = 4;

            //Вывести результат
            if (rFirstUFO + rSecondUFO <= rLea)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
