using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Журавлики__0092_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Количество журавликов
            int quantity = 24;

            //Переменные для хранения результата
            int qnt_Pet = 0;
            int qnt_Kat = 0;
            int qnt_Ser = 0;

            //Уравнение: x+x+2*2x=S
            qnt_Pet = quantity / 6;
            qnt_Kat = (quantity / 6) * 4;
            qnt_Ser = quantity / 6;

            Console.WriteLine("Решение: {0}, {1}, {2}", qnt_Pet, qnt_Kat, qnt_Ser);
            Console.ReadLine();
        }
    }
}
