using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class WeatherForecast
    {
        public int forecastTemperature;
        public string forecastCondition;

        public void GetForecast()
        {
            Random random = new Random();
            int forecastConditionRandom;
            for (int i = 0; i < 7; i++)
            {
                forecastTemperature = random.Next(50, 105);
                forecastConditionRandom = random.Next(1, 5);
                if (forecastConditionRandom == 1)
                { forecastCondition = "Sunny"; }
                else if (forecastConditionRandom == 2)
                { forecastCondition = "Hazy"; }
                else if (forecastConditionRandom == 3)
                { forecastCondition = "Cloudy"; }
                else if (forecastConditionRandom == 4)
                { forecastCondition = "Overcast"; }
                else
                { forecastCondition = "Rainy"; }
                Console.WriteLine("Day");
                Console.WriteLine("Expect a high of " + forecastTemperature + " degrees");
                Console.WriteLine("Forecast is expected to be " + forecastCondition + "\n");
            }
            Console.ReadLine();
        }


    }
}
