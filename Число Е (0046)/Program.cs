using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Число_E__0046_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Число exp до 25 знака
            string exp = "2.7182818284590452353602875";
            //Точность 
            int round = 12;
            //Для хранения разрядов
            char[] digits = new char[25];

            exp = exp.Remove(0, 2);
            for (int i = 0; i < 25; i++)
                digits[i] = exp[i];

            if (CharToInt(digits[round - 1]) == 9 && CharToInt(digits[round]) >= 5)
            {
                digits[round - 1] = (char)48;
                digits[round - 2]++;
            }
            else if (CharToInt(digits[round - 1]) != 9 && CharToInt(digits[round]) >= 5)
                digits[round - 1]++;

            //Вывод на экран
            Console.Write("Число exp c точностью до {0} знака: 2.", round);
            for (int i = 0; i < round; i++)
                Console.Write(digits[i]);

            Console.ReadLine();
        }

        static int CharToInt(char character)
        {
            return (int)character - 48;
        }
    }
}
