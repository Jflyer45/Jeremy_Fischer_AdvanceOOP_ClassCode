using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    public interface ISubscriber
    { 
        // IWeatherSubscriber would be more approp
        void Update(double temp, double humidity, double preasure);
    }
}
