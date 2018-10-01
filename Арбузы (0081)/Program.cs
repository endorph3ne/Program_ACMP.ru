using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арбузы__0081_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вес арбузов
            int[] heightWatermelons = { 2, 3, 5, 6, 7, 12 };
            //Переменные для максимального и минимального веса
            int maxHeight = Int32.MinValue;
            int minHeight = Int32.MaxValue;

            for (int i = 0; i < heightWatermelons.Length; i++)
            {
                if (heightWatermelons[i] > maxHeight)
                    maxHeight = heightWatermelons[i];
                if (heightWatermelons[i] < minHeight)
                    minHeight = heightWatermelons[i];
            }

            //Вывод на экран
            Console.WriteLine("Минимальный вес арбуза: {0}\nМаксимальный вес арбуза: {1}", minHeight, maxHeight);
            Console.ReadLine();
        }
    }
}
