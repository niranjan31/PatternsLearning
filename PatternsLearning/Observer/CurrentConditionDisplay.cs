using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Observer
{
    public class CurrentConditionDisplay : ISubscriber
    {
        IPublisher publisher;
        WeatherData weatherData;

        public CurrentConditionDisplay(IPublisher publisher)
        {
            this.publisher = publisher;
            this.publisher.AddSubscriber(this);
        }

        public void UnSubscriber()
        {
            this.publisher.RemoveSubscriber(this);
        }


        public void Update(WeatherData weatherData)
        {
            this.weatherData = weatherData;

            Console.WriteLine("Current Condition");
            Console.WriteLine("Temperature : {0}",weatherData.Temperature);
            Console.WriteLine("Pressure : {0} ", weatherData.Pressure);
            Console.WriteLine("Humidity : {0}", weatherData.Humidity);
        }

        public WeatherData GetWeatherData()
        {
            return weatherData;
        }
    }
}
