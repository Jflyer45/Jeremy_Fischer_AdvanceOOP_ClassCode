using System;

namespace ObserverLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            Cellphone myPhone = new Cellphone();

            weatherStation.Subscribe(myPhone);

            Console.WriteLine(myPhone.OutsideTemp);
            weatherStation.temp = 10.0;
            weatherStation.Notify();
            Console.WriteLine(myPhone.OutsideTemp);
        }
    }
}
