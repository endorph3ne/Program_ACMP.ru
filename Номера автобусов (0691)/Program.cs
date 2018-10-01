using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номера_автобусов__0691_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNumberOfBus = { "P204BT",
                                          "X182YZ",
                                          "a216bc",
                                          "A216BC",
                                          "ABC216" };

            for (int i = 0; i < arrayNumberOfBus.Length; i++)
                Console.WriteLine(IsNumberOfBusCorrect(arrayNumberOfBus[i]));

            Console.Read();
        }

        static string IsNumberOfBusCorrect(string number)
        {
            if (IsCharCorrect(number[0]) && Char.IsDigit(number[1]) && Char.IsDigit(number[2]) && Char.IsDigit(number[3]) && IsCharCorrect(number[4]) && IsCharCorrect(number[5]))
                return "Yes";
            return "No";
        }

        static bool IsCharCorrect(char ch)
        {
            if (ch == 'A' || ch == 'B' || ch == 'C' || ch == 'E' || ch == 'H' || ch == 'K' ||
                ch == 'M' || ch == 'O' || ch == 'P' || ch == 'T' || ch == 'X' || ch == 'Y')
                return true;
            return false;
        }
    }
}