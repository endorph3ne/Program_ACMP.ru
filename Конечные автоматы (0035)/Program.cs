using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конечные_автоматы__0035_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Параметры конечного автомата
            long n = 15;
            long m = 20;
            //Уравнение нетривиальности конечного автомата
            long d = 19 * m + (n + 239) * (n + 366) / 2;

            Console.WriteLine("Результат: {0}", d);
            Console.ReadLine();
        }
    }
}
