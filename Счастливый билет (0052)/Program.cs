using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Счастливый_билет__0052_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Счастливый билет
            int luckyTicket = 385916;
            //Хранение разрядов счастливого билета
            int[] digits = new int[6];

            int i = 0;
            while (luckyTicket != 0)
            {
                digits[i++] = luckyTicket % 10;
                luckyTicket /= 10;
            }

            int SumPartBegin = 0;
            int SumPartEnd = 0;
            for (int j = 0, k = digits.Length - 1; j < k; j++, k--)
            {
                SumPartBegin += digits[j];
                SumPartEnd += digits[k];
            }

            //Вывод на экран
            Console.WriteLine("Билет счастливый?");
            if (SumPartBegin == SumPartEnd)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}
