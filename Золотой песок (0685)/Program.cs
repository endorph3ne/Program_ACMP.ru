using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Золотой_песок__0685_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цена за песок
            int[] arrayPrice = { 1, 2, 3 };
            //Объем емкости в кг
            int[] arrayCapacity = { 3, 2, 1 };
            //Результат
            int result = 0;

            Sort(arrayPrice);
            Sort(arrayCapacity);

            for (int i = 0; i < arrayCapacity.Length; i++)
            {
                result += arrayPrice[i] * arrayCapacity[i];
            }

            Console.WriteLine("Результат: {0}", result);
            Console.ReadLine();
        }

        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                        swap(ref array[i], ref array[j]);
        }

        public static void swap(ref int first, ref int second)
        {
            int temp;
            if (first > second)
            {
                temp = second;
                second = first;
                first = temp;
            }
        }
    }
}
