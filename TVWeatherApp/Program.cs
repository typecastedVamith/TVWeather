using System;

namespace TVWeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WeatherForcast forcast = new OpenWeatherMap();
            Console.WriteLine(forcast.temperatureInDegree());

        }
    }
}
