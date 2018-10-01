using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бинарные_числа__0692_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверить является ли isBinaryNumber числом кратным 2, для представления в двоичной системе
            int number = 23;
            bool isBinaryNumber = false;

            for (int i = 2; i < 10000; i *= 2)
            {
                if (number == i)
                {
                    isBinaryNumber = true;
                    break;
                }
            }

            if (isBinaryNumber)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadLine();
        }
    }
}
