using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметическая_прогрессия__0312_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первый и второй члены арифметической прогрессии
            int a1 = 2;
            int a2 = 5;
            //Искомый по счету член прогрессии
            int number = 4;
            //Коэффициент d 
            int d = a2 - a1;

            //Подсчет и вывод на экран 
            Console.WriteLine("{0} элемент прогрессии равен: {1}", number, (a1 + d * (number - 1)));
            Console.ReadLine();

        }
    }
}
