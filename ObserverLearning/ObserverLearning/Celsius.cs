using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    public class Celsius : ITempature
    {
        public double Convert(double temp)
        {
            return temp;
        }
    }
}
