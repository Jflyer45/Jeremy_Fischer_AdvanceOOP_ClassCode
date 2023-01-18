using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    // add 1 to get around defualt package
    public interface IObserveable1
    {
        // parameters needed if you want to send data to subscribers. Else it's like unity's update.
        void Notify();
        void Subscribe(ISubscriber sub);
        void Unsubscribe(ISubscriber sub);
    }
}
