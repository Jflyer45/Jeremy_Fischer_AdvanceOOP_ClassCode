using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    class WeatherStation : IObserveable1
    {
        public double temp = 0.0;
        public double humidity = 0.0;
        public double preasure = 0.0;

        List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void Unsubscribe(ISubscriber sub)
        {
            subscribers.Remove(sub);
        }
        public void Notify()
        {
            foreach(ISubscriber subscriber in subscribers)
            {
                subscriber.Update(temp, humidity, preasure);
            }
        }

        public void SetWeatherStats(double temp, double humidity, double preasure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.preasure = preasure;
        }
    }
}
