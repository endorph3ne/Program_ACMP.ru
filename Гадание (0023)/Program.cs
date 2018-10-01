using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гадание__0023_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Число
            int number = 10;
            //Сумма чисел на которые number делится без остатка
            int sum = 0;

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    sum += i;

            //Вывод на экран
            Console.WriteLine("Сумма чисел на которые {0} делится без остатка = {1}", number, sum);
            Console.ReadLine();

        }
    }
}
