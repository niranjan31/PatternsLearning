using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Observer
{
    public interface ISubscriber
    {
        void Update(WeatherData weatherData);
    }
}
