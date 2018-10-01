using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цветочки__0504_
{
    class Program
    {
        static void Main(string[] args)
        {
            //День 
            int day = 5;

            //Определить расположение цветков в определенный день
            Console.WriteLine("Расположение цветков на {0} день: ", day);
            if (day % 3 == 0)
                Console.WriteLine("GCV");
            if (day % 3 == 1)
                Console.WriteLine("VGC");
            if (day % 3 == 2)
                Console.WriteLine("CVG");
            Console.ReadLine();
        }
    }
}
