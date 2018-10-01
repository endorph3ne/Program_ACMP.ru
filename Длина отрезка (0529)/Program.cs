using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Длина_отрезка__0529_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Координаты начала и конца отрезка
            int x1 = 3;
            int y1 = 4;
            int x2 = 8;
            int y2 = 4;

            Console.Write("Длинна отрезка: {0}", Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
            Console.ReadLine();
        }
    }
}
