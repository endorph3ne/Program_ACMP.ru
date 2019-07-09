using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Офис__0778_ {
    class Program {
        static void Main(string[] args) {
            int[] array = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 0, 0, 0, 0 };
            int countDaysOff = 4;

            int numberOfEmployees = array.Sum();
            int countWorkingDays = array.Length - countDaysOff;

            Console.WriteLine("Answer: {0}", numberOfEmployees / countWorkingDays);
            Console.ReadLine();
        }
    }
}
