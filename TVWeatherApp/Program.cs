using System;

namespace TVWeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
             WeatherForcast openWeatherApi = new OpenWeatherMap();
             Console.WriteLine("Temperature from weatherapi "+openWeatherApi.temperatureInDegree());

            WeatherForcast forcast = new NdtVWeather();
            forcast.temperatureInDegree();
            Console.WriteLine("Tempature from NDTVweatherforcast" + forcast.temperatureInDegree());

        }
    }
}
