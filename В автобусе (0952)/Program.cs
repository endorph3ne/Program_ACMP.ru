using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace В_автобусе__0952_ {
    class Program {
        static void Main(string[] args) {
            string[] inputStringArray = Console.ReadLine().Split(' ');
            int adults = Int32.Parse(inputStringArray[0]);
            int childs = Int32.Parse(inputStringArray[1]);
            int min;
            int max;

            if (adults == 0) {
                Console.Write("Impossible");
            }
            else {
                if (childs >= adults) {
                    min = adults + (childs - adults);
                    max = adults + (childs - 1);

                }
                else {
                    min = adults;
                    max = adults;
                }
                Console.WriteLine($"Answer: {min} {max}");
            }
            Console.Read();
        }
    }
}
