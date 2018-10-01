using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кольца__0894_ {
    class Program {
        static void Main(string[] args) {
            string[] inputString = Console.ReadLine().Split(' ');
            double ringArea = Convert.ToDouble(inputString[0]);
            double outsideRadius = Convert.ToDouble(inputString[1]);
            double outsideRadiusArea = Math.PI * outsideRadius * outsideRadius;
            double insideRadiusArea = outsideRadiusArea - ringArea;
            double insideRadius = Math.Round(Math.Sqrt((insideRadiusArea / Math.PI)), 3);

            Console.WriteLine("Answer: {0}", insideRadius);
            Console.Read();
        }
    }
}
