using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Observer
{
    [TestClass]
    public class ObserverUnitTest
    {
        Publisher publisher;
        CurrentConditionDisplay currentDisplay;

        public ObserverUnitTest()
        {
            publisher = new Publisher();
        }

        [TestMethod]
        public void AddCurrentDisplayTest()
        {
            currentDisplay = new CurrentConditionDisplay(publisher);
            WeatherData weatherData = new WeatherData {Humidity = 23.5f,Temperature = 28.5f,Pressure = 12f };
            publisher.SetMeasurementChanged(weatherData);

            var expected = weatherData;
            var actual = currentDisplay.GetWeatherData();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void RemoveCurrentDisplayTest()
        {
            currentDisplay = new CurrentConditionDisplay(publisher);
            currentDisplay.UnSubscriber();

            var expected = 0;
            var actual = publisher.TotalSubscribers();

            Assert.AreEqual(expected, actual);
        }
    }
}
