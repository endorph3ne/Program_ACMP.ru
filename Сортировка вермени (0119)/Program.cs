using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_времени__0119_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Time> times = new List<Time>();

            times.Add(new Time(02, 01, 02));
            times.Add(new Time(01, 01, 01));
            times.Add(new Time(00, 02, 05));

            times.Sort();

            foreach (Time t in times)
                Console.WriteLine(t);
            Console.ReadLine();
        }
    }

    class Time : IComparable
    {
        int hour;
        int minute;
        int second;

        public Time(int h, int m, int s)
        {
            this.hour = (h > 0 && h < 24) ? h : 0;
            this.minute = (m > 0 && m < 60) ? m : 0;
            this.second = (s > 0 && s < 60) ? s : 0;
        }

        int IComparable.CompareTo(object obj)
        {

            Time t = obj as Time;
            if (this.hour < t.hour || (this.hour == t.hour && this.minute < t.minute) || (this.hour == t.hour && this.minute == t.minute && this.second < t.second))
                return -1;
            else if (this.hour > t.hour || (this.hour == t.hour && this.minute > t.minute) || (this.hour == t.hour && this.minute == t.minute && this.second > t.second))
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return this.hour.ToString() + ":" + this.minute.ToString() + ":" + this.second.ToString();
        }
    }
}
