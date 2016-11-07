using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Observer
{
    public class Publisher : IPublisher
    {
        List<ISubscriber> subscribers;
        WeatherData weatherData;

        public Publisher()
        {
            subscribers = new List<ISubscriber>();
        }

        void IPublisher.AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        void IPublisher.RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void SetMeasurementChanged(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            MeasurementChanged();
        }

        private void MeasurementChanged()
        {
            ((IPublisher)this).NotifySubscribers();
        }

        void IPublisher.NotifySubscribers()
        {
            if(subscribers.Count==0)
            {
                Console.WriteLine("No Subscribers to notify");
            }
            foreach (var item in subscribers)
            {
                Console.WriteLine("Notifying :{0}",item.ToString());
                item.Update(weatherData);
            }
        }

        public int TotalSubscribers()
        {
            return subscribers.Count();
        }

       
    }
}
