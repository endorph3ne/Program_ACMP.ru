using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четырехзначный_палиндром__0324_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Число 
            int number = 6226;
            //Флаг для определения числа полинома
            bool isPalindrom = true;
            //Для хранения разрядов
            int[] arrayDigits = new int[4];

            //Разбить число на разряды
            for (int i = 0, pow = 10; number != 0; i++)
            {
                arrayDigits[i] = number % pow;
                number /= pow;
            }

            //Проверить число
            for (int i = 0, j = arrayDigits.Length - 1; i < j; i++, j--)
            {
                if (arrayDigits[i] != arrayDigits[j])
                {
                    isPalindrom = false;
                    break;
                }
            }

            if (isPalindrom)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadLine();


        }
    }
}
