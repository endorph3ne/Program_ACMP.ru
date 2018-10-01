using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клетки__0062_
{
    class Program
    {
        static void Main(string[] args)
        {
            string cell = "G8"; //Индекс ячейки
            string result = String.Empty; //Для результата
            int numericIndex; //Числовой индекс клетки

            //Решение
            for (int i = 0; i < cell.Length; i++)
            {
                numericIndex = Convert.ToInt32(cell[1]);

                switch (cell[0])
                {
                    case 'A':
                    case 'C':
                    case 'E':
                    case 'G':
                        result = numericIndex % 2 == 0 ? "White" : "Black";
                        break;
                    case 'B':
                    case 'D':
                    case 'F':
                    case 'H':
                        result = numericIndex % 2 == 0 ? "Black" : "White";
                        break;
                }
            }

            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }
    }
}
