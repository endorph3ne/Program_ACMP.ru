using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Единицы__0022_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Число
            int number = 7;
            //Количество бит со значением "1"
            int countOneBits = 0;

            //Для нахождения количества бит с "1" используем операцию побитового И
            int powerOf2 = 1;
            while (powerOf2 <= number)
            {
                if ((number & powerOf2) == powerOf2)
                    countOneBits++;
                powerOf2 *= 2;
            }

            Console.WriteLine("Answer: {0}", countOneBits);
            Console.Read();
        }
    }
}
