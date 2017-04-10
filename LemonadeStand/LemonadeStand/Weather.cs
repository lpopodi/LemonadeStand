using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int temperature;
        public string condition;

        Random random = new Random();

        public void SetWeather()
        {
            TemperatureGenerator();
            ConditionGenerator();
        }

        public int TemperatureGenerator()
        {
            Random random = new Random();
            temperature = random.Next(50, 105);
            return temperature;
        }

        public void ConditionGenerator()
        {
            int conditionRandom;
            Random random = new Random();
            conditionRandom = random.Next(1, 5);
            if (conditionRandom == 1)
            { condition = "Sunny"; }
            else if (conditionRandom == 2)
            { condition = "Hazy"; }
            else if (conditionRandom == 3)
            { condition = "Cloudy"; }
            else if (conditionRandom == 4)
            { condition = "Overcast"; }
            else
            { condition = "Rainy"; }
            
        }

    }
}
