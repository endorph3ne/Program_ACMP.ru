using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время_прибытия__0331_ {
    class Program {
        static void Main(string[] args) {
            string departureTime = "12:58";
            string travelTimeHour = "22";
            string travelTimeMinute = "6";

            int resultHour = 0;
            int resultMinute = 0;
            string resultString = String.Empty;

            int departureTimeHourD = Convert.ToInt32(departureTime.Substring(0, 2));
            int departureTimeMinuteD = Convert.ToInt32(departureTime.Substring(3, 2));
            int travelTimeHourD = Convert.ToInt32(travelTimeHour);
            int travelTimeMinuteD = Convert.ToInt32(travelTimeMinute);

            resultMinute = departureTimeMinuteD + travelTimeMinuteD;
            if (resultMinute > 59) {
                resultHour++;
                resultMinute -= 60;
            }

            resultHour += departureTimeHourD + travelTimeHourD;
            if (resultHour > 23)
                resultHour -= 24;

            resultString += resultHour < 10 ? String.Format("0{0}", resultHour) : resultHour.ToString();
            resultString += ":";
            resultString += resultMinute < 10 ? String.Format("0{0}", resultMinute) : resultMinute.ToString();

            Console.WriteLine("Answer: {0}", resultString);
            Console.Read();
        }
    }
}
