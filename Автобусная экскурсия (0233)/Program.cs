using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Автобусная_экскурсия__0233_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высота автобуса
            int busHeight = 437;
            //Массив высот мостов
            int[] bridgeHeight = { 500, 1211, 679, 1356, 437 };
            //Номер моста с которым столкнется автобус
            int numberBridge = 0;
            //Флаг столкновения автобуса с мостом 
            bool isCrash = false;

            for (int i = 0; i < bridgeHeight.Length; i++)
            {
                if (busHeight >= bridgeHeight[i])
                {
                    isCrash = true;
                    numberBridge = i + 1;
                    break;
                }
            }

            //Вывод на экран
            if (isCrash)
                Console.WriteLine("Crash {0}", numberBridge);
            else
                Console.WriteLine("No crash");
            Console.ReadLine();

        }
    }
}
