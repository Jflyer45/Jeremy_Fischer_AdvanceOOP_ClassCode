using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    interface ISubscriber
    { 
        // IWeatherSubscriber would be more approp
        void Update();
        void Subscribe();
        void Unsubscribe();
    }
}
