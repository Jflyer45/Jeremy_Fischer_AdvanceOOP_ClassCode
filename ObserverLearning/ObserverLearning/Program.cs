using System;

namespace ObserverLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            Cellphone myMetricPhone = new Cellphone();
            Cellphone myImperialPhone = new ImperialCellphone();
            CurrentConditionsObserver test = new CurrentConditionsObserver(0, 0, 0, new Fahrenheit());

            weatherStation.Subscribe(myMetricPhone);
            weatherStation.Subscribe(myImperialPhone);
            weatherStation.Subscribe(test);

            Console.WriteLine(myMetricPhone.ToString());
            Console.WriteLine(myImperialPhone.ToString());

            weatherStation.SetWeatherStats(0, 70, 100);
            weatherStation.Notify();

            Console.WriteLine(myMetricPhone.ToString());
            Console.WriteLine(myImperialPhone.ToString());
            Console.WriteLine(test.ToString());
        }
    }
}
