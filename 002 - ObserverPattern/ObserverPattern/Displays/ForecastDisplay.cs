using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
        public void Display()
        {
            if (temperature >= 25 && humidity < 80)
            {
                Console.WriteLine("Voorspelling: Mooi weer komt eraan");}
            else
            {
                Console.WriteLine("Voorspelling: Trek je paraplu's uit de kast");}
        }
    }
}