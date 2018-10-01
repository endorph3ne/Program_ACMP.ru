using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Монетки__0106_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив, указывающий как лежат монеты:
            //1 - решка 
            //0 - орел
            int[] arrayOfSideCoins = { 1, 0, 1, 0, 1, 0, 1 };
            //Счетчики для выявления сколько монет надо перевернуть
            int countHeads = 0;
            int countTails = 0;

            for (int i = 0; i < arrayOfSideCoins.Length; i++)
            {
                if (arrayOfSideCoins[i] == 1)
                    countTails++; //Увеличить счетчик монет, которые лежат решкой
                else
                    countHeads++; //орлом
            }

            //Вывести наименьшее количество монет, которые необходимо перевернуть
            if (countTails < countHeads)
                Console.WriteLine("{0} монет необходимо перевернуть", countTails);
            else
                Console.WriteLine("{0} монет необходимо перевернуть", countHeads);
            Console.ReadLine();
        }
    }
}
