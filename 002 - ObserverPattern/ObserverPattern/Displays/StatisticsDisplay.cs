using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {

            this.temperature = temp;

            sumTemperature += temp;
            countUpdated++;

            if (countUpdated == 1)
            {
                maxTemp = temp;
                minTemp = temp;
            }
            else
            {
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }

                if (temp < minTemp)
                {
                    minTemp = temp;
                }
            }Display();
        }

        public void Display()
        {
            float averageTemperature = sumTemperature / countUpdated;
            Console.WriteLine(
                $"Statistieken: Gemiddeld {averageTemperature}°C, " +
                $"Maximum {maxTemp}°C, Minimum {minTemp}°C"
            );
        }
    }
}