using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Observer
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
        void NotifySubscribers();
    }
}
