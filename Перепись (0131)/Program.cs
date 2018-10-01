using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перепись__0131_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив с информацией о людях
            int[,] arrayOfPeople = { { 25, 1 }, { 70, 1 }, { 30, 0 }, { 10, 1 } };
            //Индекс самого старого мужчины
            int indexOfOldMan = 0;
            //Максимальный возраст
            int maxYear = -1;

            //Используем array.Length/2 т.к. массив двумерный
            for (int i = 0; i < arrayOfPeople.Length / 2; i++)
            {
                if (arrayOfPeople[i, 1] == 1 && arrayOfPeople[i, 0] > maxYear)
                {
                    maxYear = arrayOfPeople[i, 0];
                    indexOfOldMan = i;
                }
            }

            Console.WriteLine("Answer: {0}", indexOfOldMan + 1);
            Console.Read();
        }
    }
}
