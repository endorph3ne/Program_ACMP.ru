using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace День_программиста__0550_
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1900;


            Console.Write("День программиста: ");
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("12/09/{0}", year);
            else
                Console.WriteLine("13/09/{0}", year);
            Console.ReadLine();
        }
    }
}
