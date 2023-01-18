using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverLearning
{
    class ImperialCellphone : Cellphone
    {
        public override void Update(double temp, double humidity, double preasure)
        {
            OutsideTemp = ConvertCelcusToFar(temp);
            OutsideHumidity = humidity;
            OutsidePreasure = PascalToPSI(preasure);
        }

        public double ConvertCelcusToFar(double c)
        {
            return (c * (9 / 5)) +32;
        }

        public double PascalToPSI(double p)
        {
            return p / 6895;
        }
    }
}
