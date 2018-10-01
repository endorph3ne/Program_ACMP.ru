using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка__0943_ {
    class Program {
        static void Main(string[] args) {
            string[] inputStringArray = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(inputStringArray[0]);
            int m = Convert.ToInt32(inputStringArray[1]);
            int yRow = Convert.ToInt32(inputStringArray[2]);
            int xColumn = Convert.ToInt32(inputStringArray[3]);
            int[,] matrix = new int[n, m];
            bool leftDirection = true;


            int count = 0;
            for (int i = 0; i < n; i++) {
                if (leftDirection)
                    for (int j = 0; j < m; j++)
                        matrix[i, j] = count++;
                else
                    for (int j = m - 1; j >= 0; j--)
                        matrix[i, j] = count++;

                leftDirection = !leftDirection;
            }

            Console.Write("Answer: {0}", matrix[yRow - 1, xColumn - 1]);
            Console.Read();
        }
    }
}
