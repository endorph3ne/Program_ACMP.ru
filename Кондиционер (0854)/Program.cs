using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кондиционер__0854_ {
    class Program {
        static void Main(string[] args) {
            int t_room = 10;
            int t_cond = 20;
            string mode = "freeze";
            int result = 0;

            switch (mode) {
                case "freeze": result = t_room < t_cond ? t_room : t_cond;
                               break;
                case "heat":   result = t_room < t_cond ? t_cond : t_room;
                               break;
                case "auto":   result = t_cond;
                               break; 
                case "fan":    result = t_room;
                               break;
            }

            Console.WriteLine("Answer: {0}", result);
            Console.Read();
        }
    }
}
