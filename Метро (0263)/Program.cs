using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метро__0263_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Количество станций
            int quantityStation = 10;
            //Начальная станция
            int startStation = 1;
            //Конечная станция
            int endStation = 9;

            //Определяем длинны маршрутов
            int firstWay = endStation - startStation;
            int secondWay = quantityStation + startStation - endStation;

            //Сравниваем полученные значения
            if (firstWay < secondWay)
                Console.WriteLine("Answer: {0}", firstWay - 1);
            else
                Console.WriteLine("Answer: {0}", secondWay - 1);
            Console.Read();
        }
    }
}
