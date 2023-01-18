using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    public class Kelvin : ITempature
    {
        public double Convert(double temp)
        {
            return temp + 273.15;
        }
    }
}
