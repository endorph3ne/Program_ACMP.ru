using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клавиатура__0066_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Клавиатурный набор букв
            string keyboard = "qwertyuiopasdfghjklzxcvbnmq";
            //Буква 
            char letter = 'p';

            Console.Write("Искомая буква: ");
            for (int i = 0; i < keyboard.Length; i++)
            {
                if (keyboard[i] == letter)
                {
                    Console.Write(keyboard[++i]);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
