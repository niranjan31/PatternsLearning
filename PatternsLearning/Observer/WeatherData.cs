using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Observer
{
    public class WeatherData
    {
        float temperature;
        float humidity;
        float pressure;

        public float Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                temperature = value;
            }
        }

        public float Humidity
        {
            get
            {
                return humidity;
            }

            set
            {
                humidity = value;
            }
        }

        public float Pressure
        {
            get
            {
                return pressure;
            }

            set
            {
                pressure = value;
            }
        }
    }
}
