using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEERC__0637_ {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputArrayString2 = Console.ReadLine().Split(' ');
            int[] array = new int[inputArrayString2.Length];
            for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToInt32(inputArrayString2[i]);
            int k = Convert.ToInt32(Console.ReadLine());

            int maxTeam = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] < k)
                    maxTeam += array[i];
                else
                    maxTeam += k;
            }

            Console.WriteLine("Answer: {0}", maxTeam);
            Console.Read();
        }
    }
}
