using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    public class Fahrenheit : ITempature
    {
        public double Convert(double temp)
        {
            return (9 / 5 * temp) + 32;
        }
    }
}
