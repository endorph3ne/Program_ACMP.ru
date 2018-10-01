using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ремонт__0697_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Параметры комнаты
            int length = 2;
            int width = 2;
            int height = 3;
            //Площадь стен 
            int S;

            S = 2 * (length * height) + 2 * (width * height);

            //Расчет количества банок краски и вывод на экран
            Console.Write("Количество банок с краской: ");
            if (S % 16 == 0)
                Console.Write(S / 16);
            else
                Console.Write((S / 16) + 1);
            Console.ReadLine();
        }
    }
}
