using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    class Cellphone : ISubscriber
    {
        private double outsideTemp = 0;
        private double outsideHumidity = 0;
        private double outsidePreasure = 0;
        public double OutsideTemp { get { return outsideTemp; } set { this.outsideTemp = value; } }
        public double OutsideHumidity { get { return outsideHumidity; } set { this.outsideHumidity = value; } }

        public double OutsidePreasure { get { return outsidePreasure; } set { this.outsidePreasure = value; } }


        public virtual void Update(double temp, double humidity, double preasure)
        {
            OutsideTemp = temp;
            OutsideHumidity = humidity;
            OutsidePreasure = preasure;
        }

        public override string ToString()
        {
            return $"Temp: {OutsideTemp} \n Hum {outsideHumidity} \n Preasure {outsidePreasure}";
        }
    }
}
