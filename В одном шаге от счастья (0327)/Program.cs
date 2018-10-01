using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace В_одном_шаге_от_счастья__0327_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Билет
            int ticket = 000001;
            //Массив для цифр билета
            int[] arrayDigitsOfTicket = new int[6];
            //Сумма первой половины цифр билета
            int sumFirstHalf = 0;
            //Сумма второй половины цифр билета
            int sumSecondHalf = 0;
            //Строка с ответом, является ли билет почти счастливым
            string result;

            int i = 0;
            while (ticket != 0)
            {
                arrayDigitsOfTicket[i++] = ticket % 10;
                ticket /= 10;
            }

            for (int j = 0; j < arrayDigitsOfTicket.Length / 2; j++)
                sumFirstHalf += arrayDigitsOfTicket[j];

            for (int j = arrayDigitsOfTicket.Length / 2; j < arrayDigitsOfTicket.Length; j++)
                sumSecondHalf += arrayDigitsOfTicket[j];

            result = (Math.Abs(sumFirstHalf - sumSecondHalf) == 1) ? "Yes" : "No";

            Console.WriteLine("Answer: {0}", result);
            Console.Read();

        }
    }
}
