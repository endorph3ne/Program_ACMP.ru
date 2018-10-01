using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кругляши__0297_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Число
            int number = 1245678;
            //Количество кругляшей
            int count = 0;
            //Строковый эквивалент числа
            string stringNumber = number.ToString();

            //Определение количества кругляшей
            for (int i = 0; i < stringNumber.Length; i++)
            {
                switch (stringNumber[i])
                {
                    case '8':
                        count += 2;
                        break;
                    case '0':
                    case '6':
                    case '9':
                        count++;
                        break;
                }
            }

            Console.WriteLine("Answer: {0}", count);
            Console.Read();
        }
    }
}
