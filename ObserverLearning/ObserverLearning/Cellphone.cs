using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    class Cellphone : ISubscriber
    {
        private double outsideTemp = 0;
        public double OutsideTemp { get { return outsideTemp; } set { this.outsideTemp = value; } }

        public void Update(double temp, double humd, double preasure)
        {
            outsideTemp = temp;
        }
    }
}
