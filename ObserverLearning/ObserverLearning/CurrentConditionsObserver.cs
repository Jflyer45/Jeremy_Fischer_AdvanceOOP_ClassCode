using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace ObserverLearning
{
    public class CurrentConditionsObserver: ISubscriber
    {
        // class Variables
        private double temperature = 0.0;
        private double humidity = 0.0;
        private double pressure = 0.0;

        private List<Double> temapatures;
        private List<Double> humidities;
        private List<Double> pressures;

        // gets and sets
        public double Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }
        }

        public double Humidity
        {
            get { return this.humidity; }
            set { this.humidity = value; }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }

        // Constructors
        public CurrentConditionsObserver():this(0.0, 0.0, 0.0)
        {

        }
        public CurrentConditionsObserver(double aTemperature, double aPressure, double aHumidity)
        {
            this.Temperature = aTemperature;
            this.Pressure = aPressure;
            this.Humidity = aHumidity;
        }

        // Methods
        public void Update(double aTemperature, double aPressure, double aHumidity)
        {
            this.Temperature = aTemperature;
            this.Pressure = aPressure;
            this.Humidity = aHumidity;

            this.temapatures.Add(aTemperature);
            this.humidities.Add(aHumidity);
            this.pressures.Add(aPressure);
        }
        public override string ToString()
        {
            string message = "";
            message = message + "The Current Conditions are: \n\n";
            message = message + "The Current Temperature is: " + this.Temperature + "\n";
            message = message + "The Current Pressure is: " + this.Pressure + "\n";
            message = message + "The Current Humidity is: " + this.Humidity + "\n";
            return message;
        }
    }
}
