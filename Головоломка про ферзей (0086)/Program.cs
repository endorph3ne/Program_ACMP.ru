using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Головоломка_про_ферзей__0086_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4; //размерность доски
            Console.WriteLine("Ответ: {0} ферзей", (n - 1) * (n - 2));
            Console.Read();
        }
    }
}
